namespace ServicioAgro_Jutiapa
{
    partial class Camara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Camara));
            btnUpload = new Button();
            btnCapture = new Button();
            picImage = new PictureBox();
            txtResult = new TextBox();
            btnVolver = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUpload
            // 
            btnUpload.BackgroundImage = (Image)resources.GetObject("btnUpload.BackgroundImage");
            btnUpload.BackgroundImageLayout = ImageLayout.Zoom;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Location = new Point(21, 243);
            btnUpload.Margin = new Padding(3, 4, 3, 4);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(65, 55);
            btnUpload.TabIndex = 0;
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += BtnUpload_Click;
            // 
            // btnCapture
            // 
            btnCapture.BackgroundImage = (Image)resources.GetObject("btnCapture.BackgroundImage");
            btnCapture.BackgroundImageLayout = ImageLayout.Zoom;
            btnCapture.FlatStyle = FlatStyle.Flat;
            btnCapture.Location = new Point(21, 126);
            btnCapture.Margin = new Padding(3, 4, 3, 4);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(65, 55);
            btnCapture.TabIndex = 1;
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += BtnCapture_Click;
            // 
            // picImage
            // 
            picImage.Location = new Point(104, 79);
            picImage.Margin = new Padding(3, 4, 3, 4);
            picImage.Name = "picImage";
            picImage.Size = new Size(358, 270);
            picImage.TabIndex = 2;
            picImage.TabStop = false;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(478, 22);
            txtResult.Margin = new Padding(3, 4, 3, 4);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(356, 387);
            txtResult.TabIndex = 3;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(710, 417);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(124, 31);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver al menu";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, -35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(866, 733);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Camara
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 458);
            Controls.Add(btnVolver);
            Controls.Add(txtResult);
            Controls.Add(picImage);
            Controls.Add(btnCapture);
            Controls.Add(btnUpload);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Camara";
            Text = "Camara";
            Load += Camara_Load;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpload;
        private Button btnCapture;
        private PictureBox picImage;
        private TextBox txtResult;
        private Button btnVolver;
        private PictureBox pictureBox1;
    }
}