namespace SerialtoSerial
{
    partial class AdvancedSettings
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
            this.comboHandshake1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboParity1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboStopbits1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboDatabits1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboDatabits2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboStopbits2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboHandshake2 = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboParity2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboHandshake1
            // 
            this.comboHandshake1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboHandshake1.FormattingEnabled = true;
            this.comboHandshake1.Location = new System.Drawing.Point(50, 43);
            this.comboHandshake1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboHandshake1.Name = "comboHandshake1";
            this.comboHandshake1.Size = new System.Drawing.Size(140, 97);
            this.comboHandshake1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Handshake";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parity";
            // 
            // comboParity1
            // 
            this.comboParity1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboParity1.FormattingEnabled = true;
            this.comboParity1.Location = new System.Drawing.Point(212, 43);
            this.comboParity1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboParity1.Name = "comboParity1";
            this.comboParity1.Size = new System.Drawing.Size(140, 97);
            this.comboParity1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stop Bits";
            // 
            // comboStopbits1
            // 
            this.comboStopbits1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboStopbits1.FormattingEnabled = true;
            this.comboStopbits1.Location = new System.Drawing.Point(374, 43);
            this.comboStopbits1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboStopbits1.Name = "comboStopbits1";
            this.comboStopbits1.Size = new System.Drawing.Size(140, 97);
            this.comboStopbits1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data Bits";
            // 
            // comboDatabits1
            // 
            this.comboDatabits1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboDatabits1.FormattingEnabled = true;
            this.comboDatabits1.Location = new System.Drawing.Point(536, 43);
            this.comboDatabits1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboDatabits1.Name = "comboDatabits1";
            this.comboDatabits1.Size = new System.Drawing.Size(140, 97);
            this.comboDatabits1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboDatabits1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboStopbits1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboParity1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboHandshake1);
            this.groupBox1.Location = new System.Drawing.Point(17, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(725, 197);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port #1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboParity2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboDatabits2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboStopbits2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboHandshake2);
            this.groupBox2.Location = new System.Drawing.Point(17, 240);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(725, 197);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port #2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Bits";
            // 
            // comboDatabits2
            // 
            this.comboDatabits2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboDatabits2.FormattingEnabled = true;
            this.comboDatabits2.Location = new System.Drawing.Point(536, 43);
            this.comboDatabits2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboDatabits2.Name = "comboDatabits2";
            this.comboDatabits2.Size = new System.Drawing.Size(140, 97);
            this.comboDatabits2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stop Bits";
            // 
            // comboStopbits2
            // 
            this.comboStopbits2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboStopbits2.FormattingEnabled = true;
            this.comboStopbits2.Location = new System.Drawing.Point(374, 43);
            this.comboStopbits2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboStopbits2.Name = "comboStopbits2";
            this.comboStopbits2.Size = new System.Drawing.Size(140, 97);
            this.comboStopbits2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Parity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Handshake";
            // 
            // comboHandshake2
            // 
            this.comboHandshake2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboHandshake2.FormattingEnabled = true;
            this.comboHandshake2.Location = new System.Drawing.Point(50, 43);
            this.comboHandshake2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboHandshake2.Name = "comboHandshake2";
            this.comboHandshake2.Size = new System.Drawing.Size(140, 97);
            this.comboHandshake2.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(767, 76);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 38);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(767, 24);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(97, 38);
            this.buttonOk.TabIndex = 13;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // comboParity2
            // 
            this.comboParity2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboParity2.FormattingEnabled = true;
            this.comboParity2.Location = new System.Drawing.Point(212, 42);
            this.comboParity2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboParity2.Name = "comboParity2";
            this.comboParity2.Size = new System.Drawing.Size(140, 97);
            this.comboParity2.TabIndex = 11;
            // 
            // AdvancedSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(889, 462);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvancedSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Advanced Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdvancedSettings_FormClosing);
            this.Shown += new System.EventHandler(this.Setup_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboHandshake1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboParity1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboStopbits1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboDatabits1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboDatabits2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboStopbits2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboHandshake2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ComboBox comboParity2;
    }
}