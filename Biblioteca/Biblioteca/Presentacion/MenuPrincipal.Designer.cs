namespace Biblioteca
{
    partial class frmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTiendas = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnEditoriales = new System.Windows.Forms.Button();
            this.btnTitulos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.tTiempo = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 55);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lblFechaHora);
            this.panel2.Controls.Add(this.btnVentas);
            this.panel2.Controls.Add(this.btnTitulos);
            this.panel2.Controls.Add(this.btnEditoriales);
            this.panel2.Controls.Add(this.btnEmpleados);
            this.panel2.Controls.Add(this.btnAutores);
            this.panel2.Controls.Add(this.btnTiendas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 397);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // btnTiendas
            // 
            this.btnTiendas.FlatAppearance.BorderSize = 0;
            this.btnTiendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiendas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiendas.Image = ((System.Drawing.Image)(resources.GetObject("btnTiendas.Image")));
            this.btnTiendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiendas.Location = new System.Drawing.Point(41, 36);
            this.btnTiendas.Name = "btnTiendas";
            this.btnTiendas.Size = new System.Drawing.Size(176, 87);
            this.btnTiendas.TabIndex = 2;
            this.btnTiendas.Text = "Tiendas";
            this.btnTiendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTiendas.UseVisualStyleBackColor = true;
            this.btnTiendas.Click += new System.EventHandler(this.btnTiendas_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.FlatAppearance.BorderSize = 0;
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.Image = ((System.Drawing.Image)(resources.GetObject("btnAutores.Image")));
            this.btnAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutores.Location = new System.Drawing.Point(266, 36);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(176, 87);
            this.btnAutores.TabIndex = 3;
            this.btnAutores.Text = "Autores";
            this.btnAutores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(41, 163);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(205, 87);
            this.btnEmpleados.TabIndex = 4;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnEditoriales
            // 
            this.btnEditoriales.FlatAppearance.BorderSize = 0;
            this.btnEditoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditoriales.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditoriales.Image = ((System.Drawing.Image)(resources.GetObject("btnEditoriales.Image")));
            this.btnEditoriales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditoriales.Location = new System.Drawing.Point(266, 163);
            this.btnEditoriales.Name = "btnEditoriales";
            this.btnEditoriales.Size = new System.Drawing.Size(202, 87);
            this.btnEditoriales.TabIndex = 5;
            this.btnEditoriales.Text = "Editoriales";
            this.btnEditoriales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditoriales.UseVisualStyleBackColor = true;
            this.btnEditoriales.Click += new System.EventHandler(this.btnEditoriales_Click);
            // 
            // btnTitulos
            // 
            this.btnTitulos.FlatAppearance.BorderSize = 0;
            this.btnTitulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitulos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitulos.Image = ((System.Drawing.Image)(resources.GetObject("btnTitulos.Image")));
            this.btnTitulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitulos.Location = new System.Drawing.Point(508, 36);
            this.btnTitulos.Name = "btnTitulos";
            this.btnTitulos.Size = new System.Drawing.Size(176, 87);
            this.btnTitulos.TabIndex = 6;
            this.btnTitulos.Text = "Titulos";
            this.btnTitulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTitulos.UseVisualStyleBackColor = true;
            this.btnTitulos.Click += new System.EventHandler(this.btnTitulos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(508, 163);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(176, 87);
            this.btnVentas.TabIndex = 7;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblFechaHora.Location = new System.Drawing.Point(480, 345);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(66, 30);
            this.lblFechaHora.TabIndex = 8;
            this.lblFechaHora.Text = "fecha";
            // 
            // tTiempo
            // 
            this.tTiempo.Interval = 1000;
            this.tTiempo.Tick += new System.EventHandler(this.tTiempo_Tick);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTiendas;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnTitulos;
        private System.Windows.Forms.Button btnEditoriales;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Timer tTiempo;
    }
}

