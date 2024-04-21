namespace CapaPresentacion
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1Registrar = new System.Windows.Forms.Button();
            this.button1Consulta = new System.Windows.Forms.Button();
            this.button2NuevoU = new System.Windows.Forms.Button();
            this.button3AtrasLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1428, 187);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Registro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.button3AtrasLogin);
            this.panel2.Controls.Add(this.button2NuevoU);
            this.panel2.Controls.Add(this.button1Consulta);
            this.panel2.Controls.Add(this.button1Registrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 564);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(403, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1025, 564);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button1Registrar
            // 
            this.button1Registrar.BackColor = System.Drawing.Color.DarkBlue;
            this.button1Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Registrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Registrar.ForeColor = System.Drawing.Color.White;
            this.button1Registrar.Location = new System.Drawing.Point(12, 46);
            this.button1Registrar.Name = "button1Registrar";
            this.button1Registrar.Size = new System.Drawing.Size(373, 69);
            this.button1Registrar.TabIndex = 0;
            this.button1Registrar.Text = "Registrar visita";
            this.button1Registrar.UseVisualStyleBackColor = false;
            this.button1Registrar.Click += new System.EventHandler(this.button1Registrar_Click);
            // 
            // button1Consulta
            // 
            this.button1Consulta.BackColor = System.Drawing.Color.DarkBlue;
            this.button1Consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Consulta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Consulta.ForeColor = System.Drawing.Color.White;
            this.button1Consulta.Location = new System.Drawing.Point(12, 149);
            this.button1Consulta.Name = "button1Consulta";
            this.button1Consulta.Size = new System.Drawing.Size(373, 69);
            this.button1Consulta.TabIndex = 1;
            this.button1Consulta.Text = "Cosultar visita";
            this.button1Consulta.UseVisualStyleBackColor = false;
            this.button1Consulta.Click += new System.EventHandler(this.button1Consulta_Click);
            // 
            // button2NuevoU
            // 
            this.button2NuevoU.BackColor = System.Drawing.Color.DarkBlue;
            this.button2NuevoU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2NuevoU.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2NuevoU.ForeColor = System.Drawing.Color.White;
            this.button2NuevoU.Location = new System.Drawing.Point(12, 251);
            this.button2NuevoU.Name = "button2NuevoU";
            this.button2NuevoU.Size = new System.Drawing.Size(373, 69);
            this.button2NuevoU.TabIndex = 2;
            this.button2NuevoU.Text = "Nuevo usuario";
            this.button2NuevoU.UseVisualStyleBackColor = false;
            this.button2NuevoU.Click += new System.EventHandler(this.button2NuevoU_Click);
            // 
            // button3AtrasLogin
            // 
            this.button3AtrasLogin.BackColor = System.Drawing.Color.DarkBlue;
            this.button3AtrasLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3AtrasLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3AtrasLogin.ForeColor = System.Drawing.Color.White;
            this.button3AtrasLogin.Location = new System.Drawing.Point(12, 351);
            this.button3AtrasLogin.Name = "button3AtrasLogin";
            this.button3AtrasLogin.Size = new System.Drawing.Size(373, 69);
            this.button3AtrasLogin.TabIndex = 3;
            this.button3AtrasLogin.Text = "Cerrar sesión";
            this.button3AtrasLogin.UseVisualStyleBackColor = false;
            this.button3AtrasLogin.Click += new System.EventHandler(this.button3AtrasLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1025, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 751);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1Registrar;
        private System.Windows.Forms.Button button3AtrasLogin;
        private System.Windows.Forms.Button button2NuevoU;
        private System.Windows.Forms.Button button1Consulta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}