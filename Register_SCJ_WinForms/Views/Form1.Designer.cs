namespace Register_SCJ_WinForms
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckBox_Confirmacion = new System.Windows.Forms.CheckBox();
            this.Textbox_DNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_Registrar = new System.Windows.Forms.Button();
            this.TextBox_Apellidos = new System.Windows.Forms.TextBox();
            this.TextBox_Nombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGrid_Alumnos = new System.Windows.Forms.DataGridView();
            this.TextBox_BuscarNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBox_BuscarApellido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBox_BuscarDNI = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(169, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Academia Sagrado Corazón de Jesús";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registrar Alumno";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckBox_Confirmacion);
            this.panel1.Controls.Add(this.Textbox_DNI);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Button_Registrar);
            this.panel1.Controls.Add(this.TextBox_Apellidos);
            this.panel1.Controls.Add(this.TextBox_Nombres);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(16, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 194);
            this.panel1.TabIndex = 2;
            // 
            // CheckBox_Confirmacion
            // 
            this.CheckBox_Confirmacion.AutoSize = true;
            this.CheckBox_Confirmacion.Checked = true;
            this.CheckBox_Confirmacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Confirmacion.Location = new System.Drawing.Point(3, 174);
            this.CheckBox_Confirmacion.Name = "CheckBox_Confirmacion";
            this.CheckBox_Confirmacion.Size = new System.Drawing.Size(113, 17);
            this.CheckBox_Confirmacion.TabIndex = 7;
            this.CheckBox_Confirmacion.Text = "Pedir confirmacion";
            this.CheckBox_Confirmacion.UseVisualStyleBackColor = true;
            // 
            // Textbox_DNI
            // 
            this.Textbox_DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_DNI.Location = new System.Drawing.Point(92, 94);
            this.Textbox_DNI.MaxLength = 8;
            this.Textbox_DNI.Name = "Textbox_DNI";
            this.Textbox_DNI.Size = new System.Drawing.Size(151, 22);
            this.Textbox_DNI.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "DNI:";
            // 
            // Button_Registrar
            // 
            this.Button_Registrar.Location = new System.Drawing.Point(113, 135);
            this.Button_Registrar.Name = "Button_Registrar";
            this.Button_Registrar.Size = new System.Drawing.Size(75, 23);
            this.Button_Registrar.TabIndex = 4;
            this.Button_Registrar.Text = "Registrar";
            this.Button_Registrar.UseVisualStyleBackColor = true;
            // 
            // TextBox_Apellidos
            // 
            this.TextBox_Apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Apellidos.Location = new System.Drawing.Point(92, 52);
            this.TextBox_Apellidos.MaxLength = 50;
            this.TextBox_Apellidos.Name = "TextBox_Apellidos";
            this.TextBox_Apellidos.Size = new System.Drawing.Size(151, 22);
            this.TextBox_Apellidos.TabIndex = 2;
            // 
            // TextBox_Nombres
            // 
            this.TextBox_Nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Nombres.Location = new System.Drawing.Point(92, 13);
            this.TextBox_Nombres.MaxLength = 50;
            this.TextBox_Nombres.Name = "TextBox_Nombres";
            this.TextBox_Nombres.Size = new System.Drawing.Size(151, 22);
            this.TextBox_Nombres.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombres:";
            // 
            // DataGrid_Alumnos
            // 
            this.DataGrid_Alumnos.AllowUserToAddRows = false;
            this.DataGrid_Alumnos.AllowUserToDeleteRows = false;
            this.DataGrid_Alumnos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_Alumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Alumnos.Location = new System.Drawing.Point(337, 134);
            this.DataGrid_Alumnos.Name = "DataGrid_Alumnos";
            this.DataGrid_Alumnos.Size = new System.Drawing.Size(443, 177);
            this.DataGrid_Alumnos.TabIndex = 3;
            // 
            // TextBox_BuscarNombre
            // 
            this.TextBox_BuscarNombre.Location = new System.Drawing.Point(394, 108);
            this.TextBox_BuscarNombre.Name = "TextBox_BuscarNombre";
            this.TextBox_BuscarNombre.Size = new System.Drawing.Size(93, 20);
            this.TextBox_BuscarNombre.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Buscar por:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Apellido:";
            // 
            // TextBox_BuscarApellido
            // 
            this.TextBox_BuscarApellido.Location = new System.Drawing.Point(559, 108);
            this.TextBox_BuscarApellido.Name = "TextBox_BuscarApellido";
            this.TextBox_BuscarApellido.Size = new System.Drawing.Size(93, 20);
            this.TextBox_BuscarApellido.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(666, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "DNI:";
            // 
            // TextBox_BuscarDNI
            // 
            this.TextBox_BuscarDNI.Location = new System.Drawing.Point(701, 108);
            this.TextBox_BuscarDNI.Name = "TextBox_BuscarDNI";
            this.TextBox_BuscarDNI.Size = new System.Drawing.Size(79, 20);
            this.TextBox_BuscarDNI.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 323);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBox_BuscarDNI);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBox_BuscarApellido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBox_BuscarNombre);
            this.Controls.Add(this.DataGrid_Alumnos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(814, 329);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Alumnos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Alumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView DataGrid_Alumnos;
        public System.Windows.Forms.TextBox TextBox_BuscarNombre;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox Textbox_DNI;
        public System.Windows.Forms.TextBox TextBox_Apellidos;
        public System.Windows.Forms.TextBox TextBox_Nombres;
        public System.Windows.Forms.Button Button_Registrar;
        public System.Windows.Forms.CheckBox CheckBox_Confirmacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox TextBox_BuscarApellido;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TextBox_BuscarDNI;
    }
}

