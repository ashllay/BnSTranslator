namespace BnSTranslator
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.TxbLocalFile = new System.Windows.Forms.TextBox();
            this.BtnSearchLocal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbOut = new System.Windows.Forms.TextBox();
            this.BtnSearchOutput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbMergeFile = new System.Windows.Forms.TextBox();
            this.BtnSearchMerge = new System.Windows.Forms.Button();
            this.BtnUnpack = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnMerge = new System.Windows.Forms.Button();
            this.BtnRepack = new System.Windows.Forms.Button();
            this.CboxBackup = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbSourceTranslate = new System.Windows.Forms.TextBox();
            this.BtnSourceSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richOut = new System.Windows.Forms.RichTextBox();
            this.BtnTranslate = new System.Windows.Forms.Button();
            this.GboxTranslator = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.GboxTranslator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "local.dat:";
            // 
            // TxbLocalFile
            // 
            this.TxbLocalFile.Location = new System.Drawing.Point(68, 13);
            this.TxbLocalFile.Name = "TxbLocalFile";
            this.TxbLocalFile.Size = new System.Drawing.Size(322, 20);
            this.TxbLocalFile.TabIndex = 1;
            // 
            // BtnSearchLocal
            // 
            this.BtnSearchLocal.Location = new System.Drawing.Point(396, 11);
            this.BtnSearchLocal.Name = "BtnSearchLocal";
            this.BtnSearchLocal.Size = new System.Drawing.Size(64, 23);
            this.BtnSearchLocal.TabIndex = 2;
            this.BtnSearchLocal.Text = "Search";
            this.BtnSearchLocal.UseVisualStyleBackColor = true;
            this.BtnSearchLocal.Click += new System.EventHandler(this.BtnSearchLocal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output:";
            // 
            // TxbOut
            // 
            this.TxbOut.Location = new System.Drawing.Point(68, 39);
            this.TxbOut.Name = "TxbOut";
            this.TxbOut.Size = new System.Drawing.Size(322, 20);
            this.TxbOut.TabIndex = 4;
            // 
            // BtnSearchOutput
            // 
            this.BtnSearchOutput.Location = new System.Drawing.Point(396, 37);
            this.BtnSearchOutput.Name = "BtnSearchOutput";
            this.BtnSearchOutput.Size = new System.Drawing.Size(64, 23);
            this.BtnSearchOutput.TabIndex = 5;
            this.BtnSearchOutput.Text = "Search";
            this.BtnSearchOutput.UseVisualStyleBackColor = true;
            this.BtnSearchOutput.Click += new System.EventHandler(this.BtnSearchOutput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "MergeFile:";
            // 
            // TxbMergeFile
            // 
            this.TxbMergeFile.Location = new System.Drawing.Point(68, 91);
            this.TxbMergeFile.Name = "TxbMergeFile";
            this.TxbMergeFile.Size = new System.Drawing.Size(322, 20);
            this.TxbMergeFile.TabIndex = 7;
            // 
            // BtnSearchMerge
            // 
            this.BtnSearchMerge.Location = new System.Drawing.Point(396, 89);
            this.BtnSearchMerge.Name = "BtnSearchMerge";
            this.BtnSearchMerge.Size = new System.Drawing.Size(64, 23);
            this.BtnSearchMerge.TabIndex = 8;
            this.BtnSearchMerge.Text = "Search";
            this.BtnSearchMerge.UseVisualStyleBackColor = true;
            this.BtnSearchMerge.Click += new System.EventHandler(this.BtnSearchMerge_Click);
            // 
            // BtnUnpack
            // 
            this.BtnUnpack.Location = new System.Drawing.Point(466, 11);
            this.BtnUnpack.Name = "BtnUnpack";
            this.BtnUnpack.Size = new System.Drawing.Size(64, 23);
            this.BtnUnpack.TabIndex = 9;
            this.BtnUnpack.Text = "Unpack";
            this.BtnUnpack.UseVisualStyleBackColor = true;
            this.BtnUnpack.Click += new System.EventHandler(this.BtnUnpack_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(466, 37);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(64, 23);
            this.BtnExport.TabIndex = 10;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnMerge
            // 
            this.BtnMerge.Location = new System.Drawing.Point(466, 88);
            this.BtnMerge.Name = "BtnMerge";
            this.BtnMerge.Size = new System.Drawing.Size(64, 23);
            this.BtnMerge.TabIndex = 11;
            this.BtnMerge.Text = "Merge";
            this.BtnMerge.UseVisualStyleBackColor = true;
            this.BtnMerge.Click += new System.EventHandler(this.BtnMerge_Click);
            // 
            // BtnRepack
            // 
            this.BtnRepack.Location = new System.Drawing.Point(466, 115);
            this.BtnRepack.Name = "BtnRepack";
            this.BtnRepack.Size = new System.Drawing.Size(64, 23);
            this.BtnRepack.TabIndex = 12;
            this.BtnRepack.Text = "Repack";
            this.BtnRepack.UseVisualStyleBackColor = true;
            this.BtnRepack.Click += new System.EventHandler(this.BtnRepack_Click);
            // 
            // CboxBackup
            // 
            this.CboxBackup.AutoSize = true;
            this.CboxBackup.Checked = true;
            this.CboxBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxBackup.Location = new System.Drawing.Point(9, 119);
            this.CboxBackup.Name = "CboxBackup";
            this.CboxBackup.Size = new System.Drawing.Size(101, 17);
            this.CboxBackup.TabIndex = 13;
            this.CboxBackup.Text = "Backup Original";
            this.CboxBackup.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SourceFile:";
            // 
            // TxbSourceTranslate
            // 
            this.TxbSourceTranslate.Location = new System.Drawing.Point(68, 65);
            this.TxbSourceTranslate.Name = "TxbSourceTranslate";
            this.TxbSourceTranslate.Size = new System.Drawing.Size(322, 20);
            this.TxbSourceTranslate.TabIndex = 7;
            // 
            // BtnSourceSearch
            // 
            this.BtnSourceSearch.Location = new System.Drawing.Point(396, 63);
            this.BtnSourceSearch.Name = "BtnSourceSearch";
            this.BtnSourceSearch.Size = new System.Drawing.Size(64, 23);
            this.BtnSourceSearch.TabIndex = 8;
            this.BtnSourceSearch.Text = "Search";
            this.BtnSourceSearch.UseVisualStyleBackColor = true;
            this.BtnSourceSearch.Click += new System.EventHandler(this.BtnSourceSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.richOut);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 115);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log:";
            // 
            // richOut
            // 
            this.richOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richOut.BackColor = System.Drawing.SystemColors.Control;
            this.richOut.HideSelection = false;
            this.richOut.Location = new System.Drawing.Point(6, 19);
            this.richOut.Name = "richOut";
            this.richOut.Size = new System.Drawing.Size(523, 90);
            this.richOut.TabIndex = 21;
            this.richOut.Text = "";
            // 
            // BtnTranslate
            // 
            this.BtnTranslate.Location = new System.Drawing.Point(396, 115);
            this.BtnTranslate.Name = "BtnTranslate";
            this.BtnTranslate.Size = new System.Drawing.Size(64, 23);
            this.BtnTranslate.TabIndex = 25;
            this.BtnTranslate.Text = "Translate";
            this.BtnTranslate.UseVisualStyleBackColor = true;
            this.BtnTranslate.Click += new System.EventHandler(this.BtnTranslate_Click);
            // 
            // GboxTranslator
            // 
            this.GboxTranslator.Controls.Add(this.comboBox1);
            this.GboxTranslator.Controls.Add(this.label1);
            this.GboxTranslator.Controls.Add(this.BtnTranslate);
            this.GboxTranslator.Controls.Add(this.TxbLocalFile);
            this.GboxTranslator.Controls.Add(this.BtnSearchLocal);
            this.GboxTranslator.Controls.Add(this.CboxBackup);
            this.GboxTranslator.Controls.Add(this.label2);
            this.GboxTranslator.Controls.Add(this.BtnRepack);
            this.GboxTranslator.Controls.Add(this.TxbOut);
            this.GboxTranslator.Controls.Add(this.BtnMerge);
            this.GboxTranslator.Controls.Add(this.BtnSearchOutput);
            this.GboxTranslator.Controls.Add(this.BtnExport);
            this.GboxTranslator.Controls.Add(this.label3);
            this.GboxTranslator.Controls.Add(this.BtnSourceSearch);
            this.GboxTranslator.Controls.Add(this.TxbMergeFile);
            this.GboxTranslator.Controls.Add(this.BtnUnpack);
            this.GboxTranslator.Controls.Add(this.label4);
            this.GboxTranslator.Controls.Add(this.TxbSourceTranslate);
            this.GboxTranslator.Controls.Add(this.BtnSearchMerge);
            this.GboxTranslator.Location = new System.Drawing.Point(12, 12);
            this.GboxTranslator.Name = "GboxTranslator";
            this.GboxTranslator.Size = new System.Drawing.Size(535, 147);
            this.GboxTranslator.TabIndex = 26;
            this.GboxTranslator.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(269, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 285);
            this.Controls.Add(this.GboxTranslator);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "BnS Translator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox2.ResumeLayout(false);
            this.GboxTranslator.ResumeLayout(false);
            this.GboxTranslator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbLocalFile;
        private System.Windows.Forms.Button BtnSearchLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbOut;
        private System.Windows.Forms.Button BtnSearchOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbMergeFile;
        private System.Windows.Forms.Button BtnSearchMerge;
        private System.Windows.Forms.Button BtnUnpack;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnMerge;
        private System.Windows.Forms.Button BtnRepack;
        private System.Windows.Forms.CheckBox CboxBackup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbSourceTranslate;
        private System.Windows.Forms.Button BtnSourceSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richOut;
        private System.Windows.Forms.Button BtnTranslate;
        private System.Windows.Forms.GroupBox GboxTranslator;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

