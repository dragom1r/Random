namespace FirstProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(148, 33);
            label1.TabIndex = 0;
            label1.Text = "Въведи име:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(180, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 34);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(336, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(212, 164);
            button1.Name = "button1";
            button1.Size = new Size(112, 51);
            button1.TabIndex = 3;
            button1.Text = "Натисни";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(584, 561);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Здравейте!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
