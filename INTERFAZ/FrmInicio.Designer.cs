namespace INTERFAZ
{
    partial class FrmInicio
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
            this.button1 = new System.Windows.Forms.Button();
            this.tsmusuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsmempleados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmproductos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmcategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tsmusuario
            // 
            this.tsmusuario.Name = "tsmusuario";
            this.tsmusuario.Size = new System.Drawing.Size(61, 20);
            this.tsmusuario.Text = "Clientes";
            this.tsmusuario.Click += new System.EventHandler(this.tsmusuario_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmusuario,
            this.tsmempleados,
            this.tsmproductos});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsmempleados
            // 
            this.tsmempleados.Name = "tsmempleados";
            this.tsmempleados.Size = new System.Drawing.Size(77, 20);
            this.tsmempleados.Text = "Empleados";
            this.tsmempleados.Click += new System.EventHandler(this.tsmempleados_Click);
            // 
            // tsmproductos
            // 
            this.tsmproductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmcategorias});
            this.tsmproductos.Name = "tsmproductos";
            this.tsmproductos.Size = new System.Drawing.Size(73, 20);
            this.tsmproductos.Text = "Productos";
            this.tsmproductos.Click += new System.EventHandler(this.tsmproductos_Click);
            // 
            // tsmcategorias
            // 
            this.tsmcategorias.Name = "tsmcategorias";
            this.tsmcategorias.Size = new System.Drawing.Size(180, 22);
            this.tsmcategorias.Text = "Categorias";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem tsmusuario;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmempleados;
        private System.Windows.Forms.ToolStripMenuItem tsmproductos;
        private System.Windows.Forms.ToolStripMenuItem tsmcategorias;
    }
}