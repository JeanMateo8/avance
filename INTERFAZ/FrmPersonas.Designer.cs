namespace INTERFAZ
{
    partial class FrmPersonas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.txtvalorbuscado = new System.Windows.Forms.TextBox();
            this.rtnombres = new System.Windows.Forms.RadioButton();
            this.rtdni = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvpersonas = new System.Windows.Forms.DataGridView();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtidpersona = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnactualizar);
            this.groupBox2.Controls.Add(this.txtvalorbuscado);
            this.groupBox2.Controls.Add(this.rtnombres);
            this.groupBox2.Controls.Add(this.rtdni);
            this.groupBox2.Location = new System.Drawing.Point(13, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 71);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Personas";
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(401, 35);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 3;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txtvalorbuscado
            // 
            this.txtvalorbuscado.Location = new System.Drawing.Point(146, 31);
            this.txtvalorbuscado.Name = "txtvalorbuscado";
            this.txtvalorbuscado.Size = new System.Drawing.Size(222, 20);
            this.txtvalorbuscado.TabIndex = 2;
            this.txtvalorbuscado.TextChanged += new System.EventHandler(this.txtvalorbuscado_TextChanged);
            // 
            // rtnombres
            // 
            this.rtnombres.AutoSize = true;
            this.rtnombres.Location = new System.Drawing.Point(78, 32);
            this.rtnombres.Name = "rtnombres";
            this.rtnombres.Size = new System.Drawing.Size(67, 17);
            this.rtnombres.TabIndex = 1;
            this.rtnombres.Text = "Nombres";
            this.rtnombres.UseVisualStyleBackColor = true;
            // 
            // rtdni
            // 
            this.rtdni.AutoSize = true;
            this.rtdni.Checked = true;
            this.rtdni.Location = new System.Drawing.Point(11, 32);
            this.rtdni.Name = "rtdni";
            this.rtdni.Size = new System.Drawing.Size(44, 17);
            this.rtdni.TabIndex = 0;
            this.rtdni.TabStop = true;
            this.rtdni.Text = "DNI";
            this.rtdni.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtidpersona);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.txtdni);
            this.groupBox1.Controls.Add(this.txtnombres);
            this.groupBox1.Controls.Add(this.txtapellidos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(974, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personas";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(105, 122);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 38);
            this.txtid.TabIndex = 11;
            this.txtid.Visible = false;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(853, 82);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(90, 27);
            this.btnmodificar.TabIndex = 9;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(853, 33);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(90, 29);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(559, 85);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttelefono.MaxLength = 9;
            this.txttelefono.Multiline = true;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(222, 22);
            this.txttelefono.TabIndex = 7;
            // 
            // txtdni
            // 
            this.txtdni.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.Location = new System.Drawing.Point(146, 85);
            this.txtdni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdni.MaxLength = 8;
            this.txtdni.Multiline = true;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(222, 22);
            this.txtdni.TabIndex = 5;
            // 
            // txtnombres
            // 
            this.txtnombres.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombres.Location = new System.Drawing.Point(559, 45);
            this.txtnombres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnombres.MaxLength = 30;
            this.txtnombres.Multiline = true;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(222, 22);
            this.txtnombres.TabIndex = 3;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidos.Location = new System.Drawing.Point(146, 45);
            this.txtapellidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtapellidos.MaxLength = 30;
            this.txtapellidos.Multiline = true;
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(222, 22);
            this.txtapellidos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dni:";
            // 
            // dgvpersonas
            // 
            this.dgvpersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpersonas.Location = new System.Drawing.Point(13, 215);
            this.dgvpersonas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvpersonas.Name = "dgvpersonas";
            this.dgvpersonas.Size = new System.Drawing.Size(975, 223);
            this.dgvpersonas.TabIndex = 5;
            this.dgvpersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpersonas_CellClick);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.RosyBrown;
            this.btnsalir.Location = new System.Drawing.Point(912, 166);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtidpersona
            // 
            this.txtidpersona.Location = new System.Drawing.Point(88, 30);
            this.txtidpersona.Multiline = true;
            this.txtidpersona.Name = "txtidpersona";
            this.txtidpersona.Size = new System.Drawing.Size(38, 20);
            this.txtidpersona.TabIndex = 12;
            this.txtidpersona.Visible = false;
            // 
            // FrmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dgvpersonas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.FrmPersonas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.TextBox txtvalorbuscado;
        private System.Windows.Forms.RadioButton rtnombres;
        private System.Windows.Forms.RadioButton rtdni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvpersonas;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtidpersona;
    }
}