namespace Proyecto_Final_Verdadero.Forms
{
    partial class Cuadratica
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRaiz = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblB1 = new System.Windows.Forms.Label();
            this.lblDeno = new System.Windows.Forms.Label();
            this.pcbCuadratica = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCuadratica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(928, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuadratica";
            // 
            // lblRaiz
            // 
            this.lblRaiz.AutoSize = true;
            this.lblRaiz.BackColor = System.Drawing.Color.White;
            this.lblRaiz.Font = new System.Drawing.Font("Microsoft YaHei", 40.2F, System.Drawing.FontStyle.Bold);
            this.lblRaiz.Location = new System.Drawing.Point(641, 61);
            this.lblRaiz.Name = "lblRaiz";
            this.lblRaiz.Size = new System.Drawing.Size(435, 91);
            this.lblRaiz.TabIndex = 2;
            this.lblRaiz.Text = "(b)²- 4(a)(c)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 38);
            this.label2.TabIndex = 4;
            // 
            // lblB1
            // 
            this.lblB1.AutoSize = true;
            this.lblB1.BackColor = System.Drawing.Color.White;
            this.lblB1.Font = new System.Drawing.Font("Microsoft YaHei", 40.2F, System.Drawing.FontStyle.Bold);
            this.lblB1.Location = new System.Drawing.Point(302, 61);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(218, 91);
            this.lblB1.TabIndex = 6;
            this.lblB1.Text = "-(b)±";
            // 
            // lblDeno
            // 
            this.lblDeno.AutoSize = true;
            this.lblDeno.BackColor = System.Drawing.Color.White;
            this.lblDeno.Font = new System.Drawing.Font("Microsoft YaHei", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeno.Location = new System.Drawing.Point(588, 208);
            this.lblDeno.Name = "lblDeno";
            this.lblDeno.Size = new System.Drawing.Size(172, 91);
            this.lblDeno.TabIndex = 7;
            this.lblDeno.Text = "2(a)";
            // 
            // pcbCuadratica
            // 
            this.pcbCuadratica.Image = global::Proyecto_Final_Verdadero.Properties.Resources.Cuadratica1;
            this.pcbCuadratica.Location = new System.Drawing.Point(12, 12);
            this.pcbCuadratica.Name = "pcbCuadratica";
            this.pcbCuadratica.Size = new System.Drawing.Size(1108, 315);
            this.pcbCuadratica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCuadratica.TabIndex = 1;
            this.pcbCuadratica.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(847, 591);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "button1";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(97, 393);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(273, 51);
            this.txtB.TabIndex = 2;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 44);
            this.label5.TabIndex = 10;
            this.label5.Text = "b =";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(97, 339);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(273, 51);
            this.txtA.TabIndex = 1;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(97, 447);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(273, 51);
            this.txtC.TabIndex = 3;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.White;
            this.lblA.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(12, 342);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(74, 44);
            this.lblA.TabIndex = 13;
            this.lblA.Text = "a =";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.White;
            this.lblC.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(12, 450);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(72, 44);
            this.lblC.TabIndex = 14;
            this.lblC.Text = "c =";
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(295, 504);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(75, 23);
            this.btnLimp.TabIndex = 15;
            this.btnLimp.Text = "Limpiar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(97, 504);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 16;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // Cuadratica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 623);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblDeno);
            this.Controls.Add(this.lblB1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRaiz);
            this.Controls.Add(this.pcbCuadratica);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cuadratica";
            this.Text = "Cuadratica";
            ((System.ComponentModel.ISupportInitialize)(this.pcbCuadratica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbCuadratica;
        private System.Windows.Forms.Label lblRaiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblB1;
        private System.Windows.Forms.Label lblDeno;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnCalc;
    }
}