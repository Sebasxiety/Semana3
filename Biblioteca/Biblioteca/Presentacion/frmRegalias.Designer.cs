namespace Publicaciones.Presentacion
{
    partial class frmRegalias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegalias));
            this.panel1 = new System.Windows.Forms.Panel();
            this.npdRangoMin = new System.Windows.Forms.NumericUpDown();
            this.npdRangoMAx = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegalias = new System.Windows.Forms.TextBox();
            this.lblFrmPersonal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdRangoMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdRangoMAx)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.npdRangoMin);
            this.panel1.Controls.Add(this.npdRangoMAx);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRegalias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 250);
            this.panel1.TabIndex = 11;
            // 
            // npdRangoMin
            // 
            this.npdRangoMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdRangoMin.Location = new System.Drawing.Point(482, 50);
            this.npdRangoMin.Name = "npdRangoMin";
            this.npdRangoMin.Size = new System.Drawing.Size(120, 26);
            this.npdRangoMin.TabIndex = 17;
            // 
            // npdRangoMAx
            // 
            this.npdRangoMAx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdRangoMAx.Location = new System.Drawing.Point(126, 53);
            this.npdRangoMAx.Name = "npdRangoMAx";
            this.npdRangoMAx.Size = new System.Drawing.Size(120, 26);
            this.npdRangoMAx.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(370, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rango Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rango Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Regalias";
            // 
            // txtRegalias
            // 
            this.txtRegalias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRegalias.Location = new System.Drawing.Point(22, 143);
            this.txtRegalias.Name = "txtRegalias";
            this.txtRegalias.Size = new System.Drawing.Size(318, 26);
            this.txtRegalias.TabIndex = 2;
            // 
            // lblFrmPersonal
            // 
            this.lblFrmPersonal.AutoSize = true;
            this.lblFrmPersonal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFrmPersonal.Location = new System.Drawing.Point(88, 13);
            this.lblFrmPersonal.Name = "lblFrmPersonal";
            this.lblFrmPersonal.Size = new System.Drawing.Size(475, 32);
            this.lblFrmPersonal.TabIndex = 10;
            this.lblFrmPersonal.Text = "Formulario de Programación de regalías";
            this.lblFrmPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblFrmPersonal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 52);
            this.panel2.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(448, 179);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(154, 59);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmRegalias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 298);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRegalias";
            this.Text = "frmProgramacionRegalias";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdRangoMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdRangoMAx)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegalias;
        private System.Windows.Forms.Label lblFrmPersonal;
        private System.Windows.Forms.NumericUpDown npdRangoMAx;
        private System.Windows.Forms.NumericUpDown npdRangoMin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuardar;
    }
}