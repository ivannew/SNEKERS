namespace SNEKERS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncola = new System.Windows.Forms.Button();
            this.butnpila = new System.Windows.Forms.Button();
            this.btnlista = new System.Windows.Forms.Button();
            this.btnarrelgo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 51);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 41);
            this.label4.TabIndex = 11;
            this.label4.Text = "IESR-LDVP";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SNEKERS.Properties.Resources._3f1d23af98bef2411d26fe5aba404916__1_;
            this.pictureBox3.Location = new System.Drawing.Point(795, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(189, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 442);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnsalir);
            this.panel2.Controls.Add(this.btncola);
            this.panel2.Controls.Add(this.butnpila);
            this.panel2.Controls.Add(this.btnlista);
            this.panel2.Controls.Add(this.btnarrelgo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 442);
            this.panel2.TabIndex = 11;
            // 
            // btncola
            // 
            this.btncola.BackColor = System.Drawing.Color.Transparent;
            this.btncola.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncola.FlatAppearance.BorderSize = 0;
            this.btncola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncola.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncola.Location = new System.Drawing.Point(0, 189);
            this.btncola.Name = "btncola";
            this.btncola.Size = new System.Drawing.Size(200, 63);
            this.btncola.TabIndex = 3;
            this.btncola.Text = "COLAS";
            this.btncola.UseVisualStyleBackColor = false;
            this.btncola.Click += new System.EventHandler(this.btncola_Click);
            // 
            // butnpila
            // 
            this.butnpila.BackColor = System.Drawing.Color.Transparent;
            this.butnpila.Dock = System.Windows.Forms.DockStyle.Top;
            this.butnpila.FlatAppearance.BorderSize = 0;
            this.butnpila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnpila.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butnpila.Location = new System.Drawing.Point(0, 126);
            this.butnpila.Name = "butnpila";
            this.butnpila.Size = new System.Drawing.Size(200, 63);
            this.butnpila.TabIndex = 2;
            this.butnpila.Text = "PILAS";
            this.butnpila.UseVisualStyleBackColor = false;
            this.butnpila.Click += new System.EventHandler(this.butnpila_Click);
            // 
            // btnlista
            // 
            this.btnlista.BackColor = System.Drawing.Color.Transparent;
            this.btnlista.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnlista.FlatAppearance.BorderSize = 0;
            this.btnlista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlista.Location = new System.Drawing.Point(0, 63);
            this.btnlista.Name = "btnlista";
            this.btnlista.Size = new System.Drawing.Size(200, 63);
            this.btnlista.TabIndex = 1;
            this.btnlista.Text = "LISTAS";
            this.btnlista.UseVisualStyleBackColor = false;
            this.btnlista.Click += new System.EventHandler(this.btnlista_Click);
            // 
            // btnarrelgo
            // 
            this.btnarrelgo.BackColor = System.Drawing.Color.Transparent;
            this.btnarrelgo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnarrelgo.FlatAppearance.BorderSize = 0;
            this.btnarrelgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnarrelgo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnarrelgo.Location = new System.Drawing.Point(0, 0);
            this.btnarrelgo.Name = "btnarrelgo";
            this.btnarrelgo.Size = new System.Drawing.Size(200, 63);
            this.btnarrelgo.TabIndex = 0;
            this.btnarrelgo.Text = "ARREGLOS";
            this.btnarrelgo.UseVisualStyleBackColor = false;
            this.btnarrelgo.Click += new System.EventHandler(this.btnarrelgo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsalir.Location = new System.Drawing.Point(0, 379);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(200, 63);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1009, 493);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnarrelgo;
        private System.Windows.Forms.Button btncola;
        private System.Windows.Forms.Button butnpila;
        private System.Windows.Forms.Button btnlista;
        private System.Windows.Forms.Button btnsalir;
    }
}

