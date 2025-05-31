namespace ServicioAgro_Jutiapa
{
    partial class PreguntasEHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreguntasEHistorial));
            label1 = new Label();
            txtPrompt = new TextBox();
            richRespuesta = new RichTextBox();
            btnBaseDatos = new Button();
            btnInvestigar = new Button();
            btnVolver = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 21);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Consulta a la IA";
            // 
            // txtPrompt
            // 
            txtPrompt.Location = new Point(47, 45);
            txtPrompt.Margin = new Padding(3, 4, 3, 4);
            txtPrompt.Name = "txtPrompt";
            txtPrompt.Size = new Size(241, 27);
            txtPrompt.TabIndex = 1;
            // 
            // richRespuesta
            // 
            richRespuesta.Location = new Point(47, 82);
            richRespuesta.Margin = new Padding(3, 4, 3, 4);
            richRespuesta.Name = "richRespuesta";
            richRespuesta.Size = new Size(855, 442);
            richRespuesta.TabIndex = 2;
            richRespuesta.Text = "";
            // 
            // btnBaseDatos
            // 
            btnBaseDatos.Location = new Point(386, 45);
            btnBaseDatos.Margin = new Padding(3, 4, 3, 4);
            btnBaseDatos.Name = "btnBaseDatos";
            btnBaseDatos.Size = new Size(86, 29);
            btnBaseDatos.TabIndex = 5;
            btnBaseDatos.Text = "Historial";
            btnBaseDatos.UseVisualStyleBackColor = true;
            btnBaseDatos.Click += btnBaseDatos_Click;
            // 
            // btnInvestigar
            // 
            btnInvestigar.Location = new Point(294, 43);
            btnInvestigar.Margin = new Padding(3, 4, 3, 4);
            btnInvestigar.Name = "btnInvestigar";
            btnInvestigar.Size = new Size(86, 31);
            btnInvestigar.TabIndex = 6;
            btnInvestigar.Text = "Consultar";
            btnInvestigar.UseVisualStyleBackColor = true;
            btnInvestigar.Click += btnInvestigar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(780, 532);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(122, 50);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Regresar Al Menu ";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(912, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // PreguntasEHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 595);
            Controls.Add(btnVolver);
            Controls.Add(btnInvestigar);
            Controls.Add(btnBaseDatos);
            Controls.Add(richRespuesta);
            Controls.Add(txtPrompt);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PreguntasEHistorial";
            Text = "PreguntasEHistorial";
            Load += PreguntasEHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPrompt;
        private RichTextBox richRespuesta;
        private Button btnBaseDatos;
        private Button btnInvestigar;
        private Button btnVolver;
        private PictureBox pictureBox1;
    }
}