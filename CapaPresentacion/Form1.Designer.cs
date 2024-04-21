namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuarioTextBox1 = new System.Windows.Forms.TextBox();
            this.ContrasenaTextBox2 = new System.Windows.Forms.TextBox();
            this.Iniciarbtn2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 325);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(248, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(211, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONTRASEÑA";
            // 
            // UsuarioTextBox1
            // 
            this.UsuarioTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsuarioTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsuarioTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox1.Location = new System.Drawing.Point(185, 399);
            this.UsuarioTextBox1.Name = "UsuarioTextBox1";
            this.UsuarioTextBox1.Size = new System.Drawing.Size(305, 37);
            this.UsuarioTextBox1.TabIndex = 3;
            this.UsuarioTextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ContrasenaTextBox2
            // 
            this.ContrasenaTextBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContrasenaTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContrasenaTextBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasenaTextBox2.Location = new System.Drawing.Point(185, 527);
            this.ContrasenaTextBox2.Name = "ContrasenaTextBox2";
            this.ContrasenaTextBox2.Size = new System.Drawing.Size(305, 37);
            this.ContrasenaTextBox2.TabIndex = 4;
            this.ContrasenaTextBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Iniciarbtn2
            // 
            this.Iniciarbtn2.BackColor = System.Drawing.Color.DarkBlue;
            this.Iniciarbtn2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iniciarbtn2.ForeColor = System.Drawing.Color.White;
            this.Iniciarbtn2.Location = new System.Drawing.Point(219, 591);
            this.Iniciarbtn2.Name = "Iniciarbtn2";
            this.Iniciarbtn2.Size = new System.Drawing.Size(244, 72);
            this.Iniciarbtn2.TabIndex = 6;
            this.Iniciarbtn2.Text = "INICIAR SESIÓN";
            this.Iniciarbtn2.UseVisualStyleBackColor = false;
            this.Iniciarbtn2.Click += new System.EventHandler(this.Iniciarbtn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 719);
            this.Controls.Add(this.Iniciarbtn2);
            this.Controls.Add(this.ContrasenaTextBox2);
            this.Controls.Add(this.UsuarioTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuarioTextBox1;
        private System.Windows.Forms.TextBox ContrasenaTextBox2;
        private System.Windows.Forms.Button Iniciarbtn2;
    }
}

