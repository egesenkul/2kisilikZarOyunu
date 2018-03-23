namespace _2OyunculuZarOyunu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skorOyuncu1 = new System.Windows.Forms.Label();
            this.skorOyuncu2 = new System.Windows.Forms.Label();
            this.btnOyuncu1 = new MetroFramework.Controls.MetroButton();
            this.btnOyuncu2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::_2OyunculuZarOyunu.Properties.Resources.zar6;
            this.pictureBox1.Location = new System.Drawing.Point(309, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // skorOyuncu1
            // 
            this.skorOyuncu1.AutoSize = true;
            this.skorOyuncu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.skorOyuncu1.Location = new System.Drawing.Point(98, 243);
            this.skorOyuncu1.Name = "skorOyuncu1";
            this.skorOyuncu1.Size = new System.Drawing.Size(23, 25);
            this.skorOyuncu1.TabIndex = 3;
            this.skorOyuncu1.Text = "0";
            this.skorOyuncu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skorOyuncu2
            // 
            this.skorOyuncu2.AutoSize = true;
            this.skorOyuncu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.skorOyuncu2.Location = new System.Drawing.Point(585, 243);
            this.skorOyuncu2.Name = "skorOyuncu2";
            this.skorOyuncu2.Size = new System.Drawing.Size(23, 25);
            this.skorOyuncu2.TabIndex = 4;
            this.skorOyuncu2.Text = "0";
            this.skorOyuncu2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOyuncu1
            // 
            this.btnOyuncu1.BackColor = System.Drawing.Color.Transparent;
            this.btnOyuncu1.Location = new System.Drawing.Point(39, 114);
            this.btnOyuncu1.Name = "btnOyuncu1";
            this.btnOyuncu1.Size = new System.Drawing.Size(125, 91);
            this.btnOyuncu1.TabIndex = 24;
            this.btnOyuncu1.Text = "ZAR AT";
            this.btnOyuncu1.UseSelectable = true;
            this.btnOyuncu1.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnOyuncu2
            // 
            this.btnOyuncu2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOyuncu2.BackColor = System.Drawing.Color.Transparent;
            this.btnOyuncu2.Location = new System.Drawing.Point(550, 114);
            this.btnOyuncu2.Name = "btnOyuncu2";
            this.btnOyuncu2.Size = new System.Drawing.Size(125, 91);
            this.btnOyuncu2.TabIndex = 25;
            this.btnOyuncu2.Text = "ZAR AT";
            this.btnOyuncu2.UseSelectable = true;
            this.btnOyuncu2.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 293);
            this.Controls.Add(this.btnOyuncu2);
            this.Controls.Add(this.btnOyuncu1);
            this.Controls.Add(this.skorOyuncu2);
            this.Controls.Add(this.skorOyuncu1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Zar Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label skorOyuncu1;
        private System.Windows.Forms.Label skorOyuncu2;
        private MetroFramework.Controls.MetroButton btnOyuncu1;
        private MetroFramework.Controls.MetroButton btnOyuncu2;
    }
}

