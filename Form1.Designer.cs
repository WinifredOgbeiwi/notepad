namespace notepad
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
            this.notepadIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.notepadIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // notepadIcon
            // 
            this.notepadIcon.BackColor = System.Drawing.Color.Transparent;
            this.notepadIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.notepadIcon.Image = global::notepad.Properties.Resources.notepad_icon1;
            this.notepadIcon.Location = new System.Drawing.Point(37, -2);
            this.notepadIcon.Name = "notepadIcon";
            this.notepadIcon.Size = new System.Drawing.Size(812, 588);
            this.notepadIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.notepadIcon.TabIndex = 0;
            this.notepadIcon.TabStop = false;
            this.notepadIcon.Click += new System.EventHandler(this.notepadIcon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::notepad.Properties.Resources.Screenshot_2024_12_12_104706;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1242, 703);
            this.Controls.Add(this.notepadIcon);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Window";
            ((System.ComponentModel.ISupportInitialize)(this.notepadIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox notepadIcon;
    }
}

