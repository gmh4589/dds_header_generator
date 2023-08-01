using System;
using System.IO;
using System.Windows.Forms;

namespace DDS_Header_Generator
{
    public partial class Form1 : Form

    {
        private string fileName = string.Empty;
        private CodecList codecList;

        public Form1()
        {
            InitializeComponent();

            codecList = new CodecList();

            string[] codecs = codecList.GetCodecList(); 
            cInput.Items.AddRange(codecs);
            cInput.SelectedIndex = Array.IndexOf(codecs, "BC3_UNORM");

            okBTN.Click += dds_save;
            cancelBTN.Click += (s, e) => this.Close();
            fileBTN.Click += fileOpen;
            folderBTN.Click += folderOpen;
        }

        private void folderOpen(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            DialogResult result = folderDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
            {
                fileName = folderDialog.SelectedPath;
                Console.WriteLine(fileName);
            }
        }

        private void fileOpen(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                fileName = openFileDialog.FileName;
                Console.WriteLine(fileName);
            }
        }


        private void dds_save(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Файл не выбран!", "ВНИМАНИЕ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FileStream sf = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                sf.Seek((long)offsetInput.Value, SeekOrigin.Begin);
                byte[] data = new byte[sf.Length - sf.Position];
                sf.Read(data, 0, data.Length);
                Console.WriteLine("Длина: " + data.Length.ToString());

                int x = (int)wInput.Value;
                int y = (int)hInput.Value;
                string codec = cInput.SelectedItem.ToString();
                byte[] bpp = codecList.GetBPP(codec);
                byte[] cdc = codecList.GetCodec(codec);
                byte[] flags = codecList.GetCodecFlags(codec);
                byte[] rgbaMask = codecList.GetRGBAMask(codec);
                byte[] h_flg = codecList.GetHeadFlags(codec);

                using (FileStream ddsFile = new FileStream("temp.dds", FileMode.Create, FileAccess.Write))
                {
                    ddsFile.Write(new byte[] { 0x44, 0x44, 0x53, 0x20, 0x7C, 0x00, 0x00, 0x00 }, 0, 8); // DDS Header
                    ddsFile.Write(h_flg, 0, 4);
                    ddsFile.Write(BitConverter.GetBytes(x), 0, 4); // Height
                    ddsFile.Write(BitConverter.GetBytes(y), 0, 4); // Width
                    ddsFile.Write(BitConverter.GetBytes(y), 0, 4); // Linear size
                    ddsFile.Write(BitConverter.GetBytes(1), 0, 4); // Depth
                    ddsFile.Write(BitConverter.GetBytes(1), 0, 4); // Mipmap count
                    ddsFile.Write(new byte[44], 0, 44); // Reserved
                    ddsFile.Write(BitConverter.GetBytes(32), 0, 4); // Reserved
                    ddsFile.Write(flags, 0, 4); // Flags
                    ddsFile.Write(cdc, 0, 4); // FourCC
                    ddsFile.Write(bpp, 0, 4); // BPP
                    ddsFile.Write(rgbaMask, 0, 16);
                    ddsFile.Write(new byte[] { 0x08, 0x10, 0x40, 0x00}, 0, 4); // Caps2
                    ddsFile.Write(new byte[16], 0, 16); // Reserved
                    ddsFile.Write(data, 0, data.Length);
                }
            }
        }
    }
}
