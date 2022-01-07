namespace LEDSign
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tbString = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.cmbCommPort = new System.Windows.Forms.ComboBox();
            this.cmbColour = new System.Windows.Forms.ComboBox();
            this.cmbFonts = new System.Windows.Forms.ComboBox();
            this.cmbTransitions = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCmdTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbString
            // 
            this.tbString.Location = new System.Drawing.Point(100, 190);
            this.tbString.Name = "tbString";
            this.tbString.Size = new System.Drawing.Size(242, 20);
            this.tbString.TabIndex = 0;
            this.tbString.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 ";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(348, 183);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(85, 32);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cmbCommPort
            // 
            this.cmbCommPort.FormattingEnabled = true;
            this.cmbCommPort.Location = new System.Drawing.Point(100, 25);
            this.cmbCommPort.Name = "cmbCommPort";
            this.cmbCommPort.Size = new System.Drawing.Size(242, 21);
            this.cmbCommPort.TabIndex = 2;
            // 
            // cmbColour
            // 
            this.cmbColour.FormattingEnabled = true;
            this.cmbColour.Location = new System.Drawing.Point(100, 69);
            this.cmbColour.Name = "cmbColour";
            this.cmbColour.Size = new System.Drawing.Size(242, 21);
            this.cmbColour.TabIndex = 3;
            // 
            // cmbFonts
            // 
            this.cmbFonts.FormattingEnabled = true;
            this.cmbFonts.Location = new System.Drawing.Point(100, 96);
            this.cmbFonts.Name = "cmbFonts";
            this.cmbFonts.Size = new System.Drawing.Size(242, 21);
            this.cmbFonts.TabIndex = 4;
            // 
            // cmbTransitions
            // 
            this.cmbTransitions.FormattingEnabled = true;
            this.cmbTransitions.Location = new System.Drawing.Point(100, 123);
            this.cmbTransitions.Name = "cmbTransitions";
            this.cmbTransitions.Size = new System.Drawing.Size(242, 21);
            this.cmbTransitions.TabIndex = 5;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(348, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(85, 31);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Com Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Colour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Font:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transition:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Message:";
            // 
            // lblCmdTxt
            // 
            this.lblCmdTxt.AutoSize = true;
            this.lblCmdTxt.Location = new System.Drawing.Point(97, 230);
            this.lblCmdTxt.Name = "lblCmdTxt";
            this.lblCmdTxt.Size = new System.Drawing.Size(75, 13);
            this.lblCmdTxt.TabIndex = 8;
            this.lblCmdTxt.Text = "CommandText";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 269);
            this.Controls.Add(this.lblCmdTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cmbTransitions);
            this.Controls.Add(this.cmbFonts);
            this.Controls.Add(this.cmbColour);
            this.Controls.Add(this.cmbCommPort);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox tbString;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cmbCommPort;
        private System.Windows.Forms.ComboBox cmbColour;
        private System.Windows.Forms.ComboBox cmbFonts;
        private System.Windows.Forms.ComboBox cmbTransitions;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCmdTxt;
    }
}

