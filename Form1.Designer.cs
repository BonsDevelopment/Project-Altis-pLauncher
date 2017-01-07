namespace Project_Altis_pLauncher
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
            this.changelogTextBox = new System.Windows.Forms.RichTextBox();
            this.usernameTextBox1 = new System.Windows.Forms.TextBox();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.sanityChecks = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadingProgress = new System.Windows.Forms.ProgressBar();
            this.versionLabel = new System.Windows.Forms.Label();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // changelogTextBox
            // 
            this.changelogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changelogTextBox.Font = new System.Drawing.Font("Impress BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelogTextBox.Location = new System.Drawing.Point(62, 156);
            this.changelogTextBox.Name = "changelogTextBox";
            this.changelogTextBox.ReadOnly = true;
            this.changelogTextBox.Size = new System.Drawing.Size(240, 350);
            this.changelogTextBox.TabIndex = 4;
            this.changelogTextBox.Text = "";
            // 
            // usernameTextBox1
            // 
            this.usernameTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox1.Font = new System.Drawing.Font("Impress BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox1.Location = new System.Drawing.Point(543, 281);
            this.usernameTextBox1.Multiline = true;
            this.usernameTextBox1.Name = "usernameTextBox1";
            this.usernameTextBox1.Size = new System.Drawing.Size(222, 23);
            this.usernameTextBox1.TabIndex = 5;
            this.usernameTextBox1.Text = "username";
            this.usernameTextBox1.WordWrap = false;
            this.usernameTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTextBox1_KeyDown);
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox1.Font = new System.Drawing.Font("Impress BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox1.Location = new System.Drawing.Point(543, 332);
            this.passwordTextBox1.Multiline = true;
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.PasswordChar = '•';
            this.passwordTextBox1.Size = new System.Drawing.Size(233, 23);
            this.passwordTextBox1.TabIndex = 6;
            this.passwordTextBox1.Text = "password";
            this.passwordTextBox1.WordWrap = false;
            this.passwordTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox1_KeyDown);
            // 
            // sanityChecks
            // 
            this.sanityChecks.Enabled = true;
            this.sanityChecks.Interval = 1000;
            this.sanityChecks.Tick += new System.EventHandler(this.sanityChecks_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(244, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 53);
            this.panel1.TabIndex = 8;
            // 
            // loadingProgress
            // 
            this.loadingProgress.Location = new System.Drawing.Point(383, 542);
            this.loadingProgress.Name = "loadingProgress";
            this.loadingProgress.Size = new System.Drawing.Size(456, 47);
            this.loadingProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadingProgress.TabIndex = 9;
            this.loadingProgress.Visible = false;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Font = new System.Drawing.Font("Impress BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.White;
            this.versionLabel.Location = new System.Drawing.Point(-5, 571);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(52, 30);
            this.versionLabel.TabIndex = 10;
            this.versionLabel.Text = "null";
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadingLabel.Font = new System.Drawing.Font("Impress BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.ForeColor = System.Drawing.Color.White;
            this.loadingLabel.Location = new System.Drawing.Point(378, 513);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(102, 26);
            this.loadingLabel.TabIndex = 11;
            this.loadingLabel.Text = "Loading..";
            this.loadingLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 601);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(829, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 21);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playButton.Location = new System.Drawing.Point(728, 370);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(66, 40);
            this.playButton.TabIndex = 14;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(851, 601);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.loadingProgress);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(this.usernameTextBox1);
            this.Controls.Add(this.changelogTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox changelogTextBox;
        private System.Windows.Forms.TextBox usernameTextBox1;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.Timer sanityChecks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar loadingProgress;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button playButton;

    }
}

