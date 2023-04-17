namespace Proyecto_Final_Verdadero.Forms
{
    partial class Cramer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cramer));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnRegre = new System.Windows.Forms.Button();
            this.lblDet = new System.Windows.Forms.Label();
            this.txtDet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 750);
            this.panel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 50);
            this.panel1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblD);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblC);
            this.panel3.Controls.Add(this.lblB);
            this.panel3.Controls.Add(this.lblA);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(729, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 360);
            this.panel3.TabIndex = 23;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Lucida Sans", 35F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(223, 141);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(164, 67);
            this.lbl1.TabIndex = 24;
            this.lbl1.Text = "(a) =";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Lucida Sans", 34.8F, System.Drawing.FontStyle.Bold);
            this.txtA.Location = new System.Drawing.Point(411, 138);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(197, 76);
            this.txtA.TabIndex = 26;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Lucida Sans", 35F, System.Drawing.FontStyle.Bold);
            this.lbl2.Location = new System.Drawing.Point(223, 221);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(168, 67);
            this.lbl2.TabIndex = 25;
            this.lbl2.Text = "(b) =";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Lucida Sans", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(411, 221);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(197, 76);
            this.txtB.TabIndex = 27;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Lucida Sans", 35F, System.Drawing.FontStyle.Bold);
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(230, 310);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(161, 67);
            this.lbl3.TabIndex = 28;
            this.lbl3.Text = "(c) =";
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Lucida Sans", 34.8F, System.Drawing.FontStyle.Bold);
            this.txtC.Location = new System.Drawing.Point(411, 307);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(197, 76);
            this.txtC.TabIndex = 30;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Lucida Sans", 35F, System.Drawing.FontStyle.Bold);
            this.lbl4.Location = new System.Drawing.Point(223, 392);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(168, 67);
            this.lbl4.TabIndex = 29;
            this.lbl4.Text = "(d) =";
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Lucida Sans", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(411, 392);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(197, 76);
            this.txtD.TabIndex = 31;
            this.txtD.TextChanged += new System.EventHandler(this.txtD_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Cooper Black", 25.2F);
            this.btnCalc.Location = new System.Drawing.Point(175, 511);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(373, 117);
            this.btnCalc.TabIndex = 32;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Font = new System.Drawing.Font("Microsoft YaHei", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimp.Location = new System.Drawing.Point(175, 634);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(373, 117);
            this.btnLimp.TabIndex = 33;
            this.btnLimp.Text = "Limpiar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnRegre
            // 
            this.btnRegre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnRegre.Location = new System.Drawing.Point(1314, 715);
            this.btnRegre.Name = "btnRegre";
            this.btnRegre.Size = new System.Drawing.Size(150, 40);
            this.btnRegre.TabIndex = 34;
            this.btnRegre.Text = "Regresar";
            this.btnRegre.UseVisualStyleBackColor = true;
            this.btnRegre.Click += new System.EventHandler(this.btnRegre_Click);
            // 
            // lblDet
            // 
            this.lblDet.AutoSize = true;
            this.lblDet.BackColor = System.Drawing.Color.Transparent;
            this.lblDet.Font = new System.Drawing.Font("Lucida Sans", 35F, System.Drawing.FontStyle.Bold);
            this.lblDet.Location = new System.Drawing.Point(825, 530);
            this.lblDet.Name = "lblDet";
            this.lblDet.Size = new System.Drawing.Size(462, 67);
            this.lblDet.TabIndex = 35;
            this.lblDet.Text = "Determinante:";
            // 
            // txtDet
            // 
            this.txtDet.Enabled = false;
            this.txtDet.Font = new System.Drawing.Font("Lucida Sans", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDet.Location = new System.Drawing.Point(843, 613);
            this.txtDet.Name = "txtDet";
            this.txtDet.ReadOnly = true;
            this.txtDet.Size = new System.Drawing.Size(450, 76);
            this.txtDet.TabIndex = 36;
            this.txtDet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 49.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 101);
            this.label1.TabIndex = 37;
            this.label1.Text = "A =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 150F);
            this.label2.Location = new System.Drawing.Point(137, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(541, 301);
            this.label2.TabIndex = 38;
            this.label2.Text = "(      )";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Bahnschrift SemiBold", 49.8F, System.Drawing.FontStyle.Bold);
            this.lblA.Location = new System.Drawing.Point(254, 77);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(88, 101);
            this.lblA.TabIndex = 39;
            this.lblA.Text = "a";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Bahnschrift SemiBold", 49.8F, System.Drawing.FontStyle.Bold);
            this.lblB.Location = new System.Drawing.Point(422, 77);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(89, 101);
            this.lblB.TabIndex = 40;
            this.lblB.Text = "b";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Bahnschrift SemiBold", 49.8F, System.Drawing.FontStyle.Bold);
            this.lblC.Location = new System.Drawing.Point(257, 188);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(85, 101);
            this.lblC.TabIndex = 41;
            this.lblC.Text = "c";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Bahnschrift SemiBold", 49.8F, System.Drawing.FontStyle.Bold);
            this.lblD.Location = new System.Drawing.Point(421, 191);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(88, 101);
            this.lblD.TabIndex = 42;
            this.lblD.Text = "d";
            // 
            // Cramer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.lblDet);
            this.Controls.Add(this.txtDet);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnRegre);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cramer";
            this.Text = "Cramer";
            this.Load += new System.EventHandler(this.Cramer_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnRegre;
        private System.Windows.Forms.Label lblDet;
        private System.Windows.Forms.TextBox txtDet;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label2;
    }
}