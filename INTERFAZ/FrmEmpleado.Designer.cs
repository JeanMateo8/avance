namespace INTERFAZ
{
    partial class FrmEmpleado
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbdesactivar = new System.Windows.Forms.RadioButton();
            this.rbmodificar = new System.Windows.Forms.RadioButton();
            this.dgvempleados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtidpersona = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.IndianRed;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(887, 22);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(70, 32);
            this.btnsalir.TabIndex = 0;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtidusuario
            // 
            this.txtidusuario.Location = new System.Drawing.Point(656, 152);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(100, 20);
            this.txtidusuario.TabIndex = 10;
            this.txtidusuario.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbdesactivar);
            this.groupBox2.Controls.Add(this.rbmodificar);
            this.groupBox2.Location = new System.Drawing.Point(638, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 56);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operación";
            // 
            // rbdesactivar
            // 
            this.rbdesactivar.AutoSize = true;
            this.rbdesactivar.Location = new System.Drawing.Point(100, 24);
            this.rbdesactivar.Name = "rbdesactivar";
            this.rbdesactivar.Size = new System.Drawing.Size(76, 17);
            this.rbdesactivar.TabIndex = 1;
            this.rbdesactivar.Text = "Desactivar";
            this.rbdesactivar.UseVisualStyleBackColor = true;
            // 
            // rbmodificar
            // 
            this.rbmodificar.AutoSize = true;
            this.rbmodificar.Location = new System.Drawing.Point(6, 24);
            this.rbmodificar.Name = "rbmodificar";
            this.rbmodificar.Size = new System.Drawing.Size(68, 17);
            this.rbmodificar.TabIndex = 0;
            this.rbmodificar.Text = "Modificar";
            this.rbmodificar.UseVisualStyleBackColor = true;
            this.rbmodificar.CheckedChanged += new System.EventHandler(this.rbmodificar_CheckedChanged);
            // 
            // dgvempleados
            // 
            this.dgvempleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleados.Location = new System.Drawing.Point(141, 210);
            this.dgvempleados.Name = "dgvempleados";
            this.dgvempleados.Size = new System.Drawing.Size(697, 252);
            this.dgvempleados.TabIndex = 8;
            this.dgvempleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleados_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnactualizar);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.btnregistrar);
            this.groupBox1.Controls.Add(this.txtclave);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.txtidpersona);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(141, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleados";
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(323, 83);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 3;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(323, 55);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 4;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(323, 26);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(75, 23);
            this.btnregistrar.TabIndex = 2;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(111, 90);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(134, 20);
            this.txtclave.TabIndex = 1;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(111, 62);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(134, 20);
            this.txtusuario.TabIndex = 1;
            // 
            // txtidpersona
            // 
            this.txtidpersona.Location = new System.Drawing.Point(111, 33);
            this.txtidpersona.Name = "txtidpersona";
            this.txtidpersona.Size = new System.Drawing.Size(134, 20);
            this.txtidpersona.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Persona:";
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 514);
            this.Controls.Add(this.txtidusuario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvempleados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtidusuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbdesactivar;
        private System.Windows.Forms.RadioButton rbmodificar;
        private System.Windows.Forms.DataGridView dgvempleados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtidpersona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}