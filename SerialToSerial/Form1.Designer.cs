namespace SerialtoSerial
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboPort1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textRx1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkCapture1 = new System.Windows.Forms.CheckBox();
            this.buttonCapture1 = new System.Windows.Forms.Button();
            this.textTxAsc1 = new System.Windows.Forms.TextBox();
            this.textRxAsc1 = new System.Windows.Forms.TextBox();
            this.checkForward1 = new System.Windows.Forms.CheckBox();
            this.checkSend1 = new System.Windows.Forms.CheckBox();
            this.comboBaud1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textTx1 = new System.Windows.Forms.TextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCapture2 = new System.Windows.Forms.Button();
            this.checkCapture2 = new System.Windows.Forms.CheckBox();
            this.textTxAsc2 = new System.Windows.Forms.TextBox();
            this.textRxAsc2 = new System.Windows.Forms.TextBox();
            this.checkForward2 = new System.Windows.Forms.CheckBox();
            this.checkSend2 = new System.Windows.Forms.CheckBox();
            this.comboBaud2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboPort2 = new System.Windows.Forms.ComboBox();
            this.textRx2 = new System.Windows.Forms.TextBox();
            this.textTx2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.setCaptureFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboPort1
            // 
            this.comboPort1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboPort1.FormattingEnabled = true;
            resources.ApplyResources(this.comboPort1, "comboPort1");
            this.comboPort1.Name = "comboPort1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // buttonStart
            // 
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textRx1
            // 
            this.textRx1.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.textRx1, "textRx1");
            this.textRx1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textRx1.Name = "textRx1";
            this.textRx1.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkCapture1);
            this.groupBox1.Controls.Add(this.buttonCapture1);
            this.groupBox1.Controls.Add(this.textTxAsc1);
            this.groupBox1.Controls.Add(this.textRxAsc1);
            this.groupBox1.Controls.Add(this.checkForward1);
            this.groupBox1.Controls.Add(this.checkSend1);
            this.groupBox1.Controls.Add(this.comboBaud1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboPort1);
            this.groupBox1.Controls.Add(this.textRx1);
            this.groupBox1.Controls.Add(this.textTx1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // checkCapture1
            // 
            resources.ApplyResources(this.checkCapture1, "checkCapture1");
            this.checkCapture1.Name = "checkCapture1";
            this.checkCapture1.UseVisualStyleBackColor = true;
            // 
            // buttonCapture1
            // 
            resources.ApplyResources(this.buttonCapture1, "buttonCapture1");
            this.buttonCapture1.Name = "buttonCapture1";
            this.buttonCapture1.UseVisualStyleBackColor = true;
            this.buttonCapture1.Click += new System.EventHandler(this.buttonCapture1_Click);
            // 
            // textTxAsc1
            // 
            this.textTxAsc1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.textTxAsc1, "textTxAsc1");
            this.textTxAsc1.Name = "textTxAsc1";
            this.textTxAsc1.ReadOnly = true;
            this.textTxAsc1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTxAsc1_KeyPress);
            // 
            // textRxAsc1
            // 
            this.textRxAsc1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textRxAsc1.CausesValidation = false;
            resources.ApplyResources(this.textRxAsc1, "textRxAsc1");
            this.textRxAsc1.Name = "textRxAsc1";
            this.textRxAsc1.ReadOnly = true;
            // 
            // checkForward1
            // 
            resources.ApplyResources(this.checkForward1, "checkForward1");
            this.checkForward1.Name = "checkForward1";
            this.checkForward1.UseVisualStyleBackColor = true;
            // 
            // checkSend1
            // 
            resources.ApplyResources(this.checkSend1, "checkSend1");
            this.checkSend1.Name = "checkSend1";
            this.checkSend1.UseVisualStyleBackColor = true;
            // 
            // comboBaud1
            // 
            this.comboBaud1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBaud1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBaud1, "comboBaud1");
            this.comboBaud1.Name = "comboBaud1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // textTx1
            // 
            this.textTx1.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.textTx1, "textTx1");
            this.textTx1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textTx1.Name = "textTx1";
            this.textTx1.ReadOnly = true;
            // 
            // buttonStop
            // 
            resources.ApplyResources(this.buttonStop, "buttonStop");
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCapture2);
            this.groupBox2.Controls.Add(this.checkCapture2);
            this.groupBox2.Controls.Add(this.textTxAsc2);
            this.groupBox2.Controls.Add(this.textRxAsc2);
            this.groupBox2.Controls.Add(this.checkForward2);
            this.groupBox2.Controls.Add(this.checkSend2);
            this.groupBox2.Controls.Add(this.comboBaud2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboPort2);
            this.groupBox2.Controls.Add(this.textRx2);
            this.groupBox2.Controls.Add(this.textTx2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // buttonCapture2
            // 
            resources.ApplyResources(this.buttonCapture2, "buttonCapture2");
            this.buttonCapture2.Name = "buttonCapture2";
            this.buttonCapture2.UseMnemonic = false;
            this.buttonCapture2.UseVisualStyleBackColor = true;
            this.buttonCapture2.Click += new System.EventHandler(this.buttonCapture2_Click);
            // 
            // checkCapture2
            // 
            resources.ApplyResources(this.checkCapture2, "checkCapture2");
            this.checkCapture2.Name = "checkCapture2";
            this.checkCapture2.UseVisualStyleBackColor = true;
            // 
            // textTxAsc2
            // 
            this.textTxAsc2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.textTxAsc2, "textTxAsc2");
            this.textTxAsc2.Name = "textTxAsc2";
            this.textTxAsc2.ReadOnly = true;
            this.textTxAsc2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTxAsc2_KeyPress);
            // 
            // textRxAsc2
            // 
            this.textRxAsc2.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.textRxAsc2, "textRxAsc2");
            this.textRxAsc2.Name = "textRxAsc2";
            this.textRxAsc2.ReadOnly = true;
            // 
            // checkForward2
            // 
            resources.ApplyResources(this.checkForward2, "checkForward2");
            this.checkForward2.Name = "checkForward2";
            this.checkForward2.UseVisualStyleBackColor = true;
            // 
            // checkSend2
            // 
            resources.ApplyResources(this.checkSend2, "checkSend2");
            this.checkSend2.Name = "checkSend2";
            this.checkSend2.UseVisualStyleBackColor = true;
            // 
            // comboBaud2
            // 
            this.comboBaud2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBaud2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBaud2, "comboBaud2");
            this.comboBaud2.Name = "comboBaud2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // comboPort2
            // 
            this.comboPort2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboPort2.FormattingEnabled = true;
            resources.ApplyResources(this.comboPort2, "comboPort2");
            this.comboPort2.Name = "comboPort2";
            // 
            // textRx2
            // 
            this.textRx2.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.textRx2, "textRx2");
            this.textRx2.Name = "textRx2";
            this.textRx2.ReadOnly = true;
            // 
            // textTx2
            // 
            this.textTx2.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.textTx2, "textTx2");
            this.textTx2.Name = "textTx2";
            this.textTx2.ReadOnly = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // buttonClear
            // 
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripFile,
            this.setupToolStripMenuItem,
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // toolStripFile
            // 
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCaptureFolderToolStripMenuItem,
            this.loadSettingsToolStripMenuItem,
            this.saveSettingsToolStripMenuItem});
            this.toolStripFile.Name = "toolStripFile";
            resources.ApplyResources(this.toolStripFile, "toolStripFile");
            // 
            // setCaptureFolderToolStripMenuItem
            // 
            this.setCaptureFolderToolStripMenuItem.Name = "setCaptureFolderToolStripMenuItem";
            resources.ApplyResources(this.setCaptureFolderToolStripMenuItem, "setCaptureFolderToolStripMenuItem");
            this.setCaptureFolderToolStripMenuItem.Click += new System.EventHandler(this.setCaptureFolderToolStripMenuItem_Click);
            // 
            // loadSettingsToolStripMenuItem
            // 
            this.loadSettingsToolStripMenuItem.Name = "loadSettingsToolStripMenuItem";
            resources.ApplyResources(this.loadSettingsToolStripMenuItem, "loadSettingsToolStripMenuItem");
            this.loadSettingsToolStripMenuItem.Click += new System.EventHandler(this.loadSettingsToolStripMenuItem_Click);
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            resources.ApplyResources(this.saveSettingsToolStripMenuItem, "saveSettingsToolStripMenuItem");
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            resources.ApplyResources(this.setupToolStripMenuItem, "setupToolStripMenuItem");
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPort1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textRx1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTx1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ComboBox comboBaud1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkSend1;
        private System.Windows.Forms.CheckBox checkForward1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkForward2;
        private System.Windows.Forms.CheckBox checkSend2;
        private System.Windows.Forms.ComboBox comboBaud2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboPort2;
        private System.Windows.Forms.TextBox textRx2;
        private System.Windows.Forms.TextBox textTx2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textRxAsc1;
        private System.Windows.Forms.TextBox textTxAsc1;
        private System.Windows.Forms.TextBox textTxAsc2;
        private System.Windows.Forms.TextBox textRxAsc2;
        private System.Windows.Forms.CheckBox checkCapture1;
        private System.Windows.Forms.CheckBox checkCapture2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCapture2;
        private System.Windows.Forms.Button buttonCapture1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripFile;
        private System.Windows.Forms.ToolStripMenuItem setCaptureFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button7;
    }
}

