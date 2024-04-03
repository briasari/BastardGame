namespace BastardGame
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.Label();
            this.optionButton2 = new System.Windows.Forms.Button();
            this.optionButton1 = new System.Windows.Forms.Button();
            this.charPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.proceedLabel = new System.Windows.Forms.Label();
            this.proceedButton = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(19, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(498, 322);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(19, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(19, 43);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.Color.Transparent;
            this.textLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.ForeColor = System.Drawing.Color.White;
            this.textLabel.Location = new System.Drawing.Point(19, 342);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(498, 148);
            this.textLabel.TabIndex = 3;
            this.textLabel.Visible = false;
            this.textLabel.Click += new System.EventHandler(this.textLabel_Click);
            // 
            // optionButton2
            // 
            this.optionButton2.Location = new System.Drawing.Point(480, 42);
            this.optionButton2.Name = "optionButton2";
            this.optionButton2.Size = new System.Drawing.Size(75, 23);
            this.optionButton2.TabIndex = 5;
            this.optionButton2.Text = "opt2";
            this.optionButton2.UseVisualStyleBackColor = true;
            this.optionButton2.Visible = false;
            this.optionButton2.Click += new System.EventHandler(this.optionButton2_Click);
            // 
            // optionButton1
            // 
            this.optionButton1.Location = new System.Drawing.Point(480, 12);
            this.optionButton1.Name = "optionButton1";
            this.optionButton1.Size = new System.Drawing.Size(75, 23);
            this.optionButton1.TabIndex = 4;
            this.optionButton1.Text = "opt1";
            this.optionButton1.UseVisualStyleBackColor = true;
            this.optionButton1.Visible = false;
            this.optionButton1.Click += new System.EventHandler(this.optionButton1_Click);
            // 
            // charPictureBox
            // 
            this.charPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.charPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.charPictureBox.Location = new System.Drawing.Point(-14, 131);
            this.charPictureBox.Name = "charPictureBox";
            this.charPictureBox.Size = new System.Drawing.Size(178, 185);
            this.charPictureBox.TabIndex = 6;
            this.charPictureBox.TabStop = false;
            this.charPictureBox.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(19, 315);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(122, 27);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Visible = false;
            // 
            // proceedLabel
            // 
            this.proceedLabel.AutoSize = true;
            this.proceedLabel.BackColor = System.Drawing.Color.Transparent;
            this.proceedLabel.ForeColor = System.Drawing.Color.White;
            this.proceedLabel.Location = new System.Drawing.Point(21, 475);
            this.proceedLabel.Name = "proceedLabel";
            this.proceedLabel.Size = new System.Drawing.Size(119, 13);
            this.proceedLabel.TabIndex = 8;
            this.proceedLabel.Text = "CLICK TO PROCEED...";
            this.proceedLabel.Visible = false;
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(480, 71);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 9;
            this.proceedButton.Text = "proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // skipButton
            // 
            this.skipButton.Location = new System.Drawing.Point(480, 100);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(75, 23);
            this.skipButton.TabIndex = 10;
            this.skipButton.Text = "skip";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(537, 499);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.proceedLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.charPictureBox);
            this.Controls.Add(this.optionButton2);
            this.Controls.Add(this.optionButton1);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Bastard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button optionButton2;
        private System.Windows.Forms.Button optionButton1;
        private System.Windows.Forms.PictureBox charPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label proceedLabel;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Button skipButton;
    }
}

