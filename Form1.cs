using System;
using System.IO;
using System.Windows.Forms;

namespace DDS_Header_Generator
{
    public partial class Form1 : Form

    {
        private string fileName = string.Empty;
        private CodecList codecList;
        bool isCubemap = false;

        public Form1()
        {
            InitializeComponent();

            codecList = new CodecList();

            string[] codecs = codecList.GetCodecList(); 
            cInput.Items.AddRange(codecs);
            cInput.SelectedIndex = Array.IndexOf(codecs, "BC3_UNORM");

            okBTN.Click += dds_save;
            fileBTN.Click += fileOpen;
            folderBTN.Click += folderOpen;
            cancelBTN.Click += cancelBTN_Click;
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

        private void dds_file_save(string codec_name, string file_name="temp")
        {
            if (!Directory.Exists("out"))
                Directory.CreateDirectory("out");

            using (FileStream sf = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                sf.Seek((long)offsetInput.Value, SeekOrigin.Begin);
                byte[] data = new byte[sf.Length - sf.Position];
                sf.Read(data, 0, data.Length);
                Console.WriteLine("Long: " + data.Length.ToString());

                int x = (int)wInput.Value;
                int y = (int)hInput.Value;

                byte[] keys = codecList.GetKeys(codec_name);
                byte[] pixel_format = codecList.GetPixelFormat(codec_name);
                byte[] depth = codecList.GetDepth(codec_name);
                byte[] rgb = codecList.GetRGB(codec_name);
                byte[] codec_data = codecList.GetCodecData(codec_name);
                byte[] name_codec = codecList.GetCodecName(codec_name);
                int codec_data_len = codec_data.Length;
                int linear_size = 0; 
                int mips_count = (int)mipsCount.Value; 
                
                if (x > y) {
                    linear_size = x;   
                } else {
                    linear_size = y; 
                }

                if (isCubemap)
                {
                    codec_data[25] = 0xFE;
                } else {
                    codec_data[25] = 0x00;
                }

                    using (FileStream ddsFile = new FileStream("out\\" + file_name + ".dds", FileMode.Create, FileAccess.Write))
                {
                    ddsFile.Write(new byte[] { 0x44, 0x44, 0x53, 0x20, 0x7C, 0x00, 0x00, 0x00 }, 0, 8); // DDS Header
                    ddsFile.Write(new byte[] { keys[0], pixel_format[0], depth[0], 0x00 }, 0, 4);
                    ddsFile.Write(BitConverter.GetBytes(x), 0, 4); // Height
                    ddsFile.Write(BitConverter.GetBytes(y), 0, 4); // Width
                    ddsFile.Write(BitConverter.GetBytes(linear_size), 0, 4); // Linear size
                    ddsFile.Write(new byte[] { 0x01, 0x00, 0x00, 0x00 }, 0, 4);
                    ddsFile.Write(BitConverter.GetBytes(mips_count), 0, 1);
                    ddsFile.Write(new byte[47], 0, 47);
                    ddsFile.Write(new byte[] { 0x20, 0x00, 0x00, 0x00 }, 0, 4);
                    ddsFile.Write(rgb, 0, 4);
                    ddsFile.Write(name_codec, 0, 4);
                    ddsFile.Write(codec_data, 0, codec_data_len);
                    ddsFile.Write(data, 0, data.Length);
                }
            }
        }

        private void dds_save(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("File not open!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string codec = cInput.SelectedItem.ToString();
            bool isDir = File.GetAttributes(fileName).HasFlag(FileAttributes.Directory);

            if (isDir)
            {
                string[] allfiles = Directory.GetFiles(fileName);
                foreach (string file in allfiles)
                {
                    Console.WriteLine(file);
                    fileName = file;
                    string out_name = Path.GetFileNameWithoutExtension(file);
                    this.dds_file_save(codec, out_name);
                }
            }
            else
            {
                string out_name = Path.GetFileNameWithoutExtension(fileName);
                this.dds_file_save(codec, out_name);
            }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            codecList = new CodecList();
            string[] codecs = codecList.GetCodecList();

            foreach (string codec in codecs)
            {
                Console.WriteLine(codec);
                this.dds_file_save(codec, codec);
            }

            MessageBox.Show("All formats are saved!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isCubemap = !isCubemap;
        }

    }
}
