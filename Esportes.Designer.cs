namespace appEducacao
{
    partial class Esportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Esportes));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textBox1 = new TextBox();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 192, 255);
            pictureBox1.Location = new Point(-5, -56);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 513);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(606, 9);
            label3.Name = "label3";
            label3.Size = new Size(177, 54);
            label3.TabIndex = 85;
            label3.Text = "Esporte ";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(536, 67);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 376);
            textBox1.TabIndex = 86;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.White;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(271, 132);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(249, 232);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 87;
            pictureBox8.TabStop = false;
            // 
            // Esportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 456);
            Controls.Add(pictureBox8);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "Esportes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBox1;
        private PictureBox pictureBox8;
    }
}