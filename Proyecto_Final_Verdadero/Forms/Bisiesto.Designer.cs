﻿namespace Proyecto_Final_Verdadero.Forms
{
    partial class Bisiesto
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F);
            this.btnCalc.Location = new System.Drawing.Point(619, 292);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(270, 117);
            this.btnCalc.TabIndex = 29;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.Transparent;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.Black;
            this.lblA.Location = new System.Drawing.Point(95, 128);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(618, 85);
            this.lblA.TabIndex = 27;
            this.lblA.Text = "Numero de Día : ";
            // 
            // txtDias
            // 
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 34.8F, System.Drawing.FontStyle.Bold);
            this.txtDias.Location = new System.Drawing.Point(363, 308);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(197, 73);
            this.txtDias.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 750);
            this.panel2.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 50);
            this.panel1.TabIndex = 25;
            // 
            // Bisiesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bisiesto";
            this.Text = "Bisiesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}