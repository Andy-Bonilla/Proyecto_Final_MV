namespace Proyecto_Final_Verdadero
{
    partial class MenuNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuNew));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbMinimize = new System.Windows.Forms.PictureBox();
            this.pcbClose = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnHerencia = new System.Windows.Forms.Button();
            this.btnCajero = new System.Windows.Forms.Button();
            this.btnCramer = new System.Windows.Forms.Button();
            this.btnAgudos = new System.Windows.Forms.Button();
            this.btnCuadratica = new System.Windows.Forms.Button();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClose)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.pnlSuperior.Controls.Add(this.label1);
            this.pnlSuperior.Controls.Add(this.pcbMinimize);
            this.pnlSuperior.Controls.Add(this.pcbClose);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1400, 50);
            this.pnlSuperior.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proyecto Final V7.0";
            // 
            // pcbMinimize
            // 
            this.pcbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pcbMinimize.Image")));
            this.pcbMinimize.Location = new System.Drawing.Point(1305, 5);
            this.pcbMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.pcbMinimize.Name = "pcbMinimize";
            this.pcbMinimize.Size = new System.Drawing.Size(41, 42);
            this.pcbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMinimize.TabIndex = 3;
            this.pcbMinimize.TabStop = false;
            this.pcbMinimize.Click += new System.EventHandler(this.pcbMinimize_Click);
            // 
            // pcbClose
            // 
            this.pcbClose.Image = ((System.Drawing.Image)(resources.GetObject("pcbClose.Image")));
            this.pcbClose.Location = new System.Drawing.Point(1354, 5);
            this.pcbClose.Margin = new System.Windows.Forms.Padding(4);
            this.pcbClose.Name = "pcbClose";
            this.pcbClose.Size = new System.Drawing.Size(42, 41);
            this.pcbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbClose.TabIndex = 2;
            this.pcbClose.TabStop = false;
            this.pcbClose.Click += new System.EventHandler(this.pcbClose_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.pnlMenu.Controls.Add(this.btnHerencia);
            this.pnlMenu.Controls.Add(this.btnCajero);
            this.pnlMenu.Controls.Add(this.btnCramer);
            this.pnlMenu.Controls.Add(this.btnAgudos);
            this.pnlMenu.Controls.Add(this.btnCuadratica);
            this.pnlMenu.Controls.Add(this.btnCreditos);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(50, 738);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnHerencia
            // 
            this.btnHerencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.btnHerencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHerencia.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerencia.ForeColor = System.Drawing.SystemColors.Info;
            this.btnHerencia.Image = ((System.Drawing.Image)(resources.GetObject("btnHerencia.Image")));
            this.btnHerencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHerencia.Location = new System.Drawing.Point(9, 342);
            this.btnHerencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnHerencia.Name = "btnHerencia";
            this.btnHerencia.Size = new System.Drawing.Size(332, 44);
            this.btnHerencia.TabIndex = 1;
            this.btnHerencia.Text = "Herencia";
            this.btnHerencia.UseVisualStyleBackColor = false;
            this.btnHerencia.Click += new System.EventHandler(this.btnHerencia_Click);
            // 
            // btnCajero
            // 
            this.btnCajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.btnCajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCajero.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajero.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCajero.Image = ((System.Drawing.Image)(resources.GetObject("btnCajero.Image")));
            this.btnCajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCajero.Location = new System.Drawing.Point(9, 394);
            this.btnCajero.Margin = new System.Windows.Forms.Padding(4);
            this.btnCajero.Name = "btnCajero";
            this.btnCajero.Size = new System.Drawing.Size(332, 44);
            this.btnCajero.TabIndex = 2;
            this.btnCajero.Text = "Cajero Del Banco";
            this.btnCajero.UseVisualStyleBackColor = false;
            this.btnCajero.Click += new System.EventHandler(this.btnCajero_Click);
            // 
            // btnCramer
            // 
            this.btnCramer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.btnCramer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCramer.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCramer.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCramer.Image = ((System.Drawing.Image)(resources.GetObject("btnCramer.Image")));
            this.btnCramer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCramer.Location = new System.Drawing.Point(9, 446);
            this.btnCramer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCramer.Name = "btnCramer";
            this.btnCramer.Size = new System.Drawing.Size(332, 44);
            this.btnCramer.TabIndex = 3;
            this.btnCramer.Text = "Regla De Cramer";
            this.btnCramer.UseVisualStyleBackColor = false;
            this.btnCramer.Click += new System.EventHandler(this.btnCramer_Click);
            // 
            // btnAgudos
            // 
            this.btnAgudos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.btnAgudos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgudos.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgudos.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAgudos.Image = ((System.Drawing.Image)(resources.GetObject("btnAgudos.Image")));
            this.btnAgudos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgudos.Location = new System.Drawing.Point(9, 498);
            this.btnAgudos.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgudos.Name = "btnAgudos";
            this.btnAgudos.Size = new System.Drawing.Size(332, 44);
            this.btnAgudos.TabIndex = 4;
            this.btnAgudos.Text = "Ángulos Agudos";
            this.btnAgudos.UseVisualStyleBackColor = false;
            this.btnAgudos.Click += new System.EventHandler(this.btnAgudos_Click);
            // 
            // btnCuadratica
            // 
            this.btnCuadratica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.btnCuadratica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuadratica.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadratica.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCuadratica.Image = ((System.Drawing.Image)(resources.GetObject("btnCuadratica.Image")));
            this.btnCuadratica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuadratica.Location = new System.Drawing.Point(9, 550);
            this.btnCuadratica.Margin = new System.Windows.Forms.Padding(4);
            this.btnCuadratica.Name = "btnCuadratica";
            this.btnCuadratica.Size = new System.Drawing.Size(332, 44);
            this.btnCuadratica.TabIndex = 5;
            this.btnCuadratica.Text = "Cuadratica";
            this.btnCuadratica.UseVisualStyleBackColor = false;
            this.btnCuadratica.Click += new System.EventHandler(this.btnCuadratica_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.btnCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreditos.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCreditos.Image = ((System.Drawing.Image)(resources.GetObject("btnCreditos.Image")));
            this.btnCreditos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreditos.Location = new System.Drawing.Point(9, 681);
            this.btnCreditos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(332, 44);
            this.btnCreditos.TabIndex = 6;
            this.btnCreditos.Text = "Créditos";
            this.btnCreditos.UseVisualStyleBackColor = false;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.Maroon;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1400, 788);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(22)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Info;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(60, 60);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(115, 50);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menú";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MenuNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1400, 788);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1400, 800);
            this.MinimumSize = new System.Drawing.Size(1364, 736);
            this.Name = "MenuNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuNew";
            this.Load += new System.EventHandler(this.MenuNew_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClose)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCreditos;
        private System.Windows.Forms.PictureBox pcbMinimize;
        private System.Windows.Forms.PictureBox pcbClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnCuadratica;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnAgudos;
        private System.Windows.Forms.Button btnHerencia;
        private System.Windows.Forms.Button btnCajero;
        private System.Windows.Forms.Button btnCramer;
    }
}