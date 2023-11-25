namespace COD4_Zonetool_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dllSelButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dllInjButton = new System.Windows.Forms.Button();
            this.refreshProcButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.instruction2Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd1Label = new System.Windows.Forms.Label();
            this.cmd2Label = new System.Windows.Forms.Label();
            this.cmd4Label = new System.Windows.Forms.Label();
            this.sendCmdButton = new System.Windows.Forms.Button();
            this.cmdBox = new System.Windows.Forms.ComboBox();
            this.cmd2Box = new System.Windows.Forms.ComboBox();
            this.customCmd2Box = new System.Windows.Forms.TextBox();
            this.cmd3Label = new System.Windows.Forms.Label();
            this.cmdHintLabel = new System.Windows.Forms.Label();
            this.cmdHint2Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(4, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(279, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Path to zonetoolDLL";
            // 
            // dllSelButton
            // 
            this.dllSelButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dllSelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dllSelButton.ForeColor = System.Drawing.SystemColors.Window;
            this.dllSelButton.Location = new System.Drawing.Point(289, 75);
            this.dllSelButton.Name = "dllSelButton";
            this.dllSelButton.Size = new System.Drawing.Size(95, 26);
            this.dllSelButton.TabIndex = 2;
            this.dllSelButton.Text = "Choose DLL";
            this.dllSelButton.UseVisualStyleBackColor = false;
            this.dllSelButton.Click += new System.EventHandler(this.dllSelButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(380, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // dllInjButton
            // 
            this.dllInjButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dllInjButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dllInjButton.ForeColor = System.Drawing.SystemColors.Window;
            this.dllInjButton.Location = new System.Drawing.Point(4, 137);
            this.dllInjButton.Name = "dllInjButton";
            this.dllInjButton.Size = new System.Drawing.Size(380, 28);
            this.dllInjButton.TabIndex = 4;
            this.dllInjButton.Text = "Inject DLL";
            this.dllInjButton.UseVisualStyleBackColor = false;
            this.dllInjButton.Click += new System.EventHandler(this.dllInjButton_Click);
            // 
            // refreshProcButton
            // 
            this.refreshProcButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.refreshProcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshProcButton.ForeColor = System.Drawing.SystemColors.Window;
            this.refreshProcButton.Location = new System.Drawing.Point(4, 171);
            this.refreshProcButton.Name = "refreshProcButton";
            this.refreshProcButton.Size = new System.Drawing.Size(380, 26);
            this.refreshProcButton.TabIndex = 5;
            this.refreshProcButton.Text = "Refresh Process List";
            this.refreshProcButton.UseVisualStyleBackColor = false;
            this.refreshProcButton.Click += new System.EventHandler(this.refreshProcButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.infoLabel.Location = new System.Drawing.Point(4, 491);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(142, 16);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "zonetool manager v2.0";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(5, 436);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(140, 16);
            this.instructionLabel.TabIndex = 7;
            this.instructionLabel.Text = "Supported processes:";
            // 
            // instruction2Label
            // 
            this.instruction2Label.AutoSize = true;
            this.instruction2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction2Label.Location = new System.Drawing.Point(5, 457);
            this.instruction2Label.Name = "instruction2Label";
            this.instruction2Label.Size = new System.Drawing.Size(100, 16);
            this.instruction2Label.TabIndex = 8;
            this.instruction2Label.Text = "Supported dll\'s:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Commands:";
            // 
            // cmd1Label
            // 
            this.cmd1Label.AutoSize = true;
            this.cmd1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd1Label.Location = new System.Drawing.Point(61, 365);
            this.cmd1Label.Name = "cmd1Label";
            this.cmd1Label.Size = new System.Drawing.Size(251, 16);
            this.cmd1Label.TabIndex = 10;
            this.cmd1Label.Text = "loadzone <zone> - load a zone as source";
            // 
            // cmd2Label
            // 
            this.cmd2Label.AutoSize = true;
            this.cmd2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd2Label.Location = new System.Drawing.Point(61, 381);
            this.cmd2Label.Name = "cmd2Label";
            this.cmd2Label.Size = new System.Drawing.Size(193, 16);
            this.cmd2Label.TabIndex = 11;
            this.cmd2Label.Text = "buildzone <zone> - build a zone";
            // 
            // cmd4Label
            // 
            this.cmd4Label.AutoSize = true;
            this.cmd4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd4Label.Location = new System.Drawing.Point(61, 411);
            this.cmd4Label.Name = "cmd4Label";
            this.cmd4Label.Size = new System.Drawing.Size(141, 16);
            this.cmd4Label.TabIndex = 12;
            this.cmd4Label.Text = "quit - quits the program";
            // 
            // sendCmdButton
            // 
            this.sendCmdButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sendCmdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendCmdButton.ForeColor = System.Drawing.SystemColors.Window;
            this.sendCmdButton.Location = new System.Drawing.Point(4, 283);
            this.sendCmdButton.Name = "sendCmdButton";
            this.sendCmdButton.Size = new System.Drawing.Size(380, 26);
            this.sendCmdButton.TabIndex = 13;
            this.sendCmdButton.Text = "Send command";
            this.sendCmdButton.UseVisualStyleBackColor = false;
            this.sendCmdButton.Click += new System.EventHandler(this.sendCmdButton_Click);
            // 
            // cmdBox
            // 
            this.cmdBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.cmdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBox.ForeColor = System.Drawing.SystemColors.Window;
            this.cmdBox.FormattingEnabled = true;
            this.cmdBox.Location = new System.Drawing.Point(4, 242);
            this.cmdBox.Name = "cmdBox";
            this.cmdBox.Size = new System.Drawing.Size(134, 24);
            this.cmdBox.TabIndex = 14;
            // 
            // cmd2Box
            // 
            this.cmd2Box.BackColor = System.Drawing.SystemColors.MenuText;
            this.cmd2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd2Box.ForeColor = System.Drawing.SystemColors.Window;
            this.cmd2Box.FormattingEnabled = true;
            this.cmd2Box.Location = new System.Drawing.Point(143, 242);
            this.cmd2Box.Name = "cmd2Box";
            this.cmd2Box.Size = new System.Drawing.Size(131, 24);
            this.cmd2Box.TabIndex = 15;
            // 
            // customCmd2Box
            // 
            this.customCmd2Box.BackColor = System.Drawing.SystemColors.MenuText;
            this.customCmd2Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customCmd2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customCmd2Box.ForeColor = System.Drawing.SystemColors.Window;
            this.customCmd2Box.Location = new System.Drawing.Point(280, 244);
            this.customCmd2Box.Name = "customCmd2Box";
            this.customCmd2Box.Size = new System.Drawing.Size(104, 22);
            this.customCmd2Box.TabIndex = 16;
            this.customCmd2Box.Text = "your command";
            // 
            // cmd3Label
            // 
            this.cmd3Label.AutoSize = true;
            this.cmd3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd3Label.Location = new System.Drawing.Point(61, 397);
            this.cmd3Label.Name = "cmd3Label";
            this.cmd3Label.Size = new System.Drawing.Size(203, 16);
            this.cmd3Label.TabIndex = 17;
            this.cmd3Label.Text = "dumpzone <zone> - dump a zone";
            // 
            // cmdHintLabel
            // 
            this.cmdHintLabel.AutoSize = true;
            this.cmdHintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHintLabel.Location = new System.Drawing.Point(5, 223);
            this.cmdHintLabel.Name = "cmdHintLabel";
            this.cmdHintLabel.Size = new System.Drawing.Size(92, 13);
            this.cmdHintLabel.TabIndex = 18;
            this.cmdHintLabel.Text = "Choose command";
            // 
            // cmdHint2Label
            // 
            this.cmdHint2Label.AutoSize = true;
            this.cmdHint2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHint2Label.Location = new System.Drawing.Point(148, 223);
            this.cmdHint2Label.Name = "cmdHint2Label";
            this.cmdHint2Label.Size = new System.Drawing.Size(228, 13);
            this.cmdHint2Label.TabIndex = 19;
            this.cmdHint2Label.Text = "Choose zone             or write your custom zone";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 69);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(91, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "COD4 Zonetool Manager";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.Window;
            this.exit.Location = new System.Drawing.Point(358, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 29);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 519);
            this.Controls.Add(this.cmdHint2Label);
            this.Controls.Add(this.cmdHintLabel);
            this.Controls.Add(this.cmd3Label);
            this.Controls.Add(this.customCmd2Box);
            this.Controls.Add(this.cmd2Box);
            this.Controls.Add(this.cmdBox);
            this.Controls.Add(this.sendCmdButton);
            this.Controls.Add(this.cmd4Label);
            this.Controls.Add(this.cmd2Label);
            this.Controls.Add(this.cmd1Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.instruction2Label);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.refreshProcButton);
            this.Controls.Add(this.dllInjButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dllSelButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zonetool Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button dllSelButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button dllInjButton;
        private System.Windows.Forms.Button refreshProcButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label instruction2Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cmd1Label;
        private System.Windows.Forms.Label cmd2Label;
        private System.Windows.Forms.Label cmd4Label;
        private System.Windows.Forms.Button sendCmdButton;
        private System.Windows.Forms.ComboBox cmdBox;
        private System.Windows.Forms.ComboBox cmd2Box;
        private System.Windows.Forms.TextBox customCmd2Box;
        private System.Windows.Forms.Label cmd3Label;
        private System.Windows.Forms.Label cmdHintLabel;
        private System.Windows.Forms.Label cmdHint2Label;
    }
}

