namespace ServicioAgro_Jutiapa
{
    partial class Clima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clima));
            btnInvestigar = new Button();
            lblLugar = new Label();
            lblTemperatura = new Label();
            lblHumedad = new Label();
            lblViento = new Label();
            txtPrompt = new TextBox();
            txtLugar = new TextBox();
            btnVolver = new Button();
            lblError = new Label();
            txtRecomendacion = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnInvestigar
            // 
            btnInvestigar.FlatStyle = FlatStyle.Flat;
            btnInvestigar.Location = new Point(219, 51);
            btnInvestigar.Margin = new Padding(3, 4, 3, 4);
            btnInvestigar.Name = "btnInvestigar";
            btnInvestigar.Size = new Size(86, 28);
            btnInvestigar.TabIndex = 0;
            btnInvestigar.Text = "Investigar";
            btnInvestigar.UseVisualStyleBackColor = true;
            btnInvestigar.Click += btnInvestigar_Click;
            // 
            // lblLugar
            // 
            lblLugar.AutoSize = true;
            lblLugar.Location = new Point(60, 251);
            lblLugar.Name = "lblLugar";
            lblLugar.Size = new Size(0, 20);
            lblLugar.TabIndex = 2;
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Location = new Point(60, 308);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(0, 20);
            lblTemperatura.TabIndex = 3;
            // 
            // lblHumedad
            // 
            lblHumedad.AutoSize = true;
            lblHumedad.Location = new Point(60, 366);
            lblHumedad.Name = "lblHumedad";
            lblHumedad.Size = new Size(0, 20);
            lblHumedad.TabIndex = 5;
            // 
            // lblViento
            // 
            lblViento.AutoSize = true;
            lblViento.Location = new Point(60, 422);
            lblViento.Name = "lblViento";
            lblViento.Size = new Size(0, 20);
            lblViento.TabIndex = 6;
            // 
            // txtPrompt
            // 
            txtPrompt.Location = new Point(27, 127);
            txtPrompt.Margin = new Padding(3, 4, 3, 4);
            txtPrompt.Name = "txtPrompt";
            txtPrompt.Size = new Size(186, 27);
            txtPrompt.TabIndex = 7;
            txtPrompt.Tag = "";
            // 
            // txtLugar
            // 
            txtLugar.Location = new Point(27, 51);
            txtLugar.Margin = new Padding(3, 4, 3, 4);
            txtLugar.Multiline = true;
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(186, 26);
            txtLugar.TabIndex = 8;
            txtLugar.Tag = "";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(758, 488);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(133, 31);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Regresar al menú";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(27, 467);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 11;
            // 
            // txtRecomendacion
            // 
            txtRecomendacion.AccessibleName = "hola";
            txtRecomendacion.Location = new Point(387, 16);
            txtRecomendacion.Margin = new Padding(3, 4, 3, 4);
            txtRecomendacion.Multiline = true;
            txtRecomendacion.Name = "txtRecomendacion";
            txtRecomendacion.ReadOnly = true;
            txtRecomendacion.ScrollBars = ScrollBars.Vertical;
            txtRecomendacion.Size = new Size(504, 453);
            txtRecomendacion.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(914, 561);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Clima
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 532);
            Controls.Add(txtRecomendacion);
            Controls.Add(lblError);
            Controls.Add(btnVolver);
            Controls.Add(txtLugar);
            Controls.Add(txtPrompt);
            Controls.Add(lblViento);
            Controls.Add(lblHumedad);
            Controls.Add(lblTemperatura);
            Controls.Add(lblLugar);
            Controls.Add(btnInvestigar);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Clima";
            Text = "Clima";
            Load += Clima_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInvestigar;
        private Label lblLugar;
        private Label lblTemperatura;
        private Label lblHumedad;
        private Label lblViento;
        private TextBox txtPrompt;
        private TextBox txtLugar;
        private Label lblError;
        private Button btnVolver;
        private TextBox txtRecomendacion;
        private PictureBox pictureBox1;
    }
}