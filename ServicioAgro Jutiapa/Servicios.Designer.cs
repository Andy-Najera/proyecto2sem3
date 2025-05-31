namespace ServicioAgro_Jutiapa
{
    partial class Servicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicios));
            btnCamara = new Button();
            btnIA = new Button();
            btnClima = new Button();
            SuspendLayout();
            // 
            // btnCamara
            // 
            btnCamara.BackgroundImage = (Image)resources.GetObject("btnCamara.BackgroundImage");
            btnCamara.BackgroundImageLayout = ImageLayout.Zoom;
            btnCamara.FlatStyle = FlatStyle.Flat;
            btnCamara.ForeColor = Color.Transparent;
            btnCamara.Location = new Point(-6, 216);
            btnCamara.Margin = new Padding(3, 4, 3, 4);
            btnCamara.Name = "btnCamara";
            btnCamara.Size = new Size(678, 216);
            btnCamara.TabIndex = 6;
            btnCamara.UseVisualStyleBackColor = true;
            btnCamara.Click += BtnCamara_Click;
            // 
            // btnIA
            // 
            btnIA.BackgroundImage = (Image)resources.GetObject("btnIA.BackgroundImage");
            btnIA.BackgroundImageLayout = ImageLayout.Zoom;
            btnIA.FlatStyle = FlatStyle.Flat;
            btnIA.ForeColor = Color.Transparent;
            btnIA.Location = new Point(-6, 428);
            btnIA.Margin = new Padding(3, 4, 3, 4);
            btnIA.Name = "btnIA";
            btnIA.Size = new Size(668, 242);
            btnIA.TabIndex = 7;
            btnIA.UseVisualStyleBackColor = true;
            btnIA.Click += BtnIA_Click;
            // 
            // btnClima
            // 
            btnClima.BackgroundImage = (Image)resources.GetObject("btnClima.BackgroundImage");
            btnClima.BackgroundImageLayout = ImageLayout.Zoom;
            btnClima.FlatStyle = FlatStyle.Flat;
            btnClima.ForeColor = Color.Transparent;
            btnClima.Location = new Point(-37, -9);
            btnClima.Margin = new Padding(3, 4, 3, 4);
            btnClima.Name = "btnClima";
            btnClima.Size = new Size(740, 226);
            btnClima.TabIndex = 8;
            btnClima.UseVisualStyleBackColor = true;
            btnClima.Click += BtnClima_Click;
            // 
            // Servicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 662);
            Controls.Add(btnCamara);
            Controls.Add(btnClima);
            Controls.Add(btnIA);
            ForeColor = Color.Transparent;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Servicios";
            Text = "Servicios";
            Load += Servicios_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnCamara;
        private Button btnIA;
        private Button btnClima;
    }
}