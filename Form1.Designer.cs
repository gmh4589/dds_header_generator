namespace DDS_Header_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fileBTN = new System.Windows.Forms.Button();
            this.okBTN = new System.Windows.Forms.Button();
            this.folderBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.hInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.offsetInput = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mipsCount = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mipsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.fileBTN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.okBTN, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.folderBTN, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cancelBTN, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 167);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // fileBTN
            // 
            this.fileBTN.Location = new System.Drawing.Point(3, 3);
            this.fileBTN.Name = "fileBTN";
            this.fileBTN.Size = new System.Drawing.Size(94, 31);
            this.fileBTN.TabIndex = 0;
            this.fileBTN.Text = "Open file";
            this.fileBTN.UseVisualStyleBackColor = true;
            // 
            // okBTN
            // 
            this.okBTN.Location = new System.Drawing.Point(103, 3);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(94, 31);
            this.okBTN.TabIndex = 1;
            this.okBTN.Text = "Save file(s)";
            this.okBTN.UseVisualStyleBackColor = true;
            // 
            // folderBTN
            // 
            this.folderBTN.Location = new System.Drawing.Point(3, 40);
            this.folderBTN.Name = "folderBTN";
            this.folderBTN.Size = new System.Drawing.Size(94, 27);
            this.folderBTN.TabIndex = 2;
            this.folderBTN.Text = "Open folder";
            this.folderBTN.UseVisualStyleBackColor = true;
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(103, 40);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(94, 27);
            this.cancelBTN.TabIndex = 3;
            this.cancelBTN.Text = "Save All Type";
            this.cancelBTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Height";
            // 
            // wInput
            // 
            this.wInput.Location = new System.Drawing.Point(10, 30);
            this.wInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.wInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wInput.Name = "wInput";
            this.wInput.Size = new System.Drawing.Size(97, 20);
            this.wInput.TabIndex = 2;
            this.wInput.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            // 
            // hInput
            // 
            this.hInput.Location = new System.Drawing.Point(115, 30);
            this.hInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.hInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hInput.Name = "hInput";
            this.hInput.Size = new System.Drawing.Size(97, 20);
            this.hInput.TabIndex = 4;
            this.hInput.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codec";
            // 
            // cInput
            // 
            this.cInput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cInput.FormattingEnabled = true;
            this.cInput.Location = new System.Drawing.Point(10, 69);
            this.cInput.Name = "cInput";
            this.cInput.Size = new System.Drawing.Size(200, 21);
            this.cInput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Offset";
            // 
            // offsetInput
            // 
            this.offsetInput.Location = new System.Drawing.Point(10, 109);
            this.offsetInput.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.offsetInput.Name = "offsetInput";
            this.offsetInput.Size = new System.Drawing.Size(97, 20);
            this.offsetInput.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Is cubemap";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mips count";
            // 
            // mipsCount
            // 
            this.mipsCount.Location = new System.Drawing.Point(115, 110);
            this.mipsCount.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.mipsCount.Name = "mipsCount";
            this.mipsCount.Size = new System.Drawing.Size(97, 20);
            this.mipsCount.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 250);
            this.Controls.Add(this.mipsCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.offsetInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "DDS HG";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mipsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button fileBTN;
        private System.Windows.Forms.Button okBTN;
        private System.Windows.Forms.Button folderBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown wInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown hInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown offsetInput;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown mipsCount;
    }
}

