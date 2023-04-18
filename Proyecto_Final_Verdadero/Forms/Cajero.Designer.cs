namespace Proyecto_Final_Verdadero.Forms
{
    partial class Cajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cajero));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDepo = new System.Windows.Forms.Button();
            this.txtCan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblA = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReti = new System.Windows.Forms.Button();
            this.btnRegre = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.txtD5 = new System.Windows.Forms.TextBox();
            this.txtD20 = new System.Windows.Forms.TextBox();
            this.txtD10 = new System.Windows.Forms.TextBox();
            this.txtD100 = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(53, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1347, 49);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 800);
            this.panel1.TabIndex = 10;
            // 
            // btnDepo
            // 
            this.btnDepo.Font = new System.Drawing.Font("Microsoft YaHei", 25.2F, System.Drawing.FontStyle.Bold);
            this.btnDepo.Location = new System.Drawing.Point(175, 397);
            this.btnDepo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDepo.Name = "btnDepo";
            this.btnDepo.Size = new System.Drawing.Size(270, 117);
            this.btnDepo.TabIndex = 12;
            this.btnDepo.Text = "Depositar";
            this.btnDepo.UseVisualStyleBackColor = true;
            this.btnDepo.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // txtCan
            // 
            this.txtCan.Font = new System.Drawing.Font("Lucida Sans", 34.8F, System.Drawing.FontStyle.Bold);
            this.txtCan.Location = new System.Drawing.Point(76, 4);
            this.txtCan.Margin = new System.Windows.Forms.Padding(4);
            this.txtCan.Name = "txtCan";
            this.txtCan.Size = new System.Drawing.Size(233, 76);
            this.txtCan.TabIndex = 13;
            this.txtCan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCan_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 689);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.Transparent;
            this.lblA.Font = new System.Drawing.Font("Lucida Sans", 34.8F, System.Drawing.FontStyle.Bold);
            this.lblA.ForeColor = System.Drawing.Color.Black;
            this.lblA.Location = new System.Drawing.Point(4, 7);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(65, 66);
            this.lblA.TabIndex = 15;
            this.lblA.Text = "$";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblA);
            this.panel3.Controls.Add(this.txtCan);
            this.panel3.Location = new System.Drawing.Point(183, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 85);
            this.panel3.TabIndex = 16;
            // 
            // btnReti
            // 
            this.btnReti.Font = new System.Drawing.Font("Microsoft YaHei", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReti.Location = new System.Drawing.Point(175, 548);
            this.btnReti.Name = "btnReti";
            this.btnReti.Size = new System.Drawing.Size(270, 117);
            this.btnReti.TabIndex = 17;
            this.btnReti.Text = "Retirar";
            this.btnReti.UseVisualStyleBackColor = true;
            this.btnReti.Click += new System.EventHandler(this.btnReti_Click);
            // 
            // btnRegre
            // 
            this.btnRegre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnRegre.Location = new System.Drawing.Point(1310, 713);
            this.btnRegre.Name = "btnRegre";
            this.btnRegre.Size = new System.Drawing.Size(150, 40);
            this.btnRegre.TabIndex = 18;
            this.btnRegre.Text = "Regresar";
            this.btnRegre.UseVisualStyleBackColor = true;
            this.btnRegre.Click += new System.EventHandler(this.btnRegre_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(756, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(756, 353);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(301, 144);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(925, 557);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(301, 144);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1091, 353);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(301, 144);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1082, 150);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(301, 144);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // txtD1
            // 
            this.txtD1.Enabled = false;
            this.txtD1.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold);
            this.txtD1.Location = new System.Drawing.Point(776, 300);
            this.txtD1.Name = "txtD1";
            this.txtD1.ReadOnly = true;
            this.txtD1.Size = new System.Drawing.Size(260, 47);
            this.txtD1.TabIndex = 24;
            this.txtD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtD5
            // 
            this.txtD5.Enabled = false;
            this.txtD5.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold);
            this.txtD5.Location = new System.Drawing.Point(1104, 300);
            this.txtD5.Name = "txtD5";
            this.txtD5.ReadOnly = true;
            this.txtD5.Size = new System.Drawing.Size(260, 47);
            this.txtD5.TabIndex = 25;
            this.txtD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtD20
            // 
            this.txtD20.Enabled = false;
            this.txtD20.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold);
            this.txtD20.Location = new System.Drawing.Point(1104, 504);
            this.txtD20.Name = "txtD20";
            this.txtD20.ReadOnly = true;
            this.txtD20.Size = new System.Drawing.Size(260, 47);
            this.txtD20.TabIndex = 27;
            this.txtD20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtD10
            // 
            this.txtD10.Enabled = false;
            this.txtD10.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold);
            this.txtD10.Location = new System.Drawing.Point(776, 504);
            this.txtD10.Name = "txtD10";
            this.txtD10.ReadOnly = true;
            this.txtD10.Size = new System.Drawing.Size(260, 47);
            this.txtD10.TabIndex = 26;
            this.txtD10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtD100
            // 
            this.txtD100.Enabled = false;
            this.txtD100.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold);
            this.txtD100.Location = new System.Drawing.Point(949, 708);
            this.txtD100.Name = "txtD100";
            this.txtD100.ReadOnly = true;
            this.txtD100.Size = new System.Drawing.Size(260, 47);
            this.txtD100.TabIndex = 28;
            this.txtD100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold);
            this.txtSaldo.Location = new System.Drawing.Point(1142, 72);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(260, 47);
            this.txtSaldo.TabIndex = 29;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1097, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(699, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 39);
            this.label2.TabIndex = 30;
            this.label2.Text = "Saldo en su cuenta:";
            // 
            // Cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtD100);
            this.Controls.Add(this.txtD20);
            this.Controls.Add(this.txtD10);
            this.Controls.Add(this.txtD5);
            this.Controls.Add(this.txtD1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRegre);
            this.Controls.Add(this.btnReti);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnDepo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cajero";
            this.Text = "Cajero";
            this.Load += new System.EventHandler(this.Cajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDepo;
        private System.Windows.Forms.TextBox txtCan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReti;
        private System.Windows.Forms.Button btnRegre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.TextBox txtD5;
        private System.Windows.Forms.TextBox txtD20;
        private System.Windows.Forms.TextBox txtD10;
        private System.Windows.Forms.TextBox txtD100;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}