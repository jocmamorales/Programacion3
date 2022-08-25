namespace Ejemplo1
{
    partial class Form1
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
            this.botonAgregar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelFNac = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.labSexo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.numUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.labEdad = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gBoxEstCivil = new System.Windows.Forms.GroupBox();
            this.ckboxSoltero = new System.Windows.Forms.CheckBox();
            this.cboxCasado = new System.Windows.Forms.CheckBox();
            this.cboxViudo = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownEdad)).BeginInit();
            this.gBoxEstCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonAgregar
            // 
            this.botonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.botonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAgregar.Location = new System.Drawing.Point(261, 376);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(88, 25);
            this.botonAgregar.TabIndex = 7;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = false;
            this.botonAgregar.Click += new System.EventHandler(this.boton1_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(76, 56);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombre.Location = new System.Drawing.Point(129, 56);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(217, 20);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // LabelFNac
            // 
            this.LabelFNac.AutoSize = true;
            this.LabelFNac.Location = new System.Drawing.Point(12, 82);
            this.LabelFNac.Name = "LabelFNac";
            this.LabelFNac.Size = new System.Drawing.Size(111, 13);
            this.LabelFNac.TabIndex = 4;
            this.LabelFNac.Text = "Fecha de Nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(3, 3);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(68, 17);
            this.rbMasc.TabIndex = 0;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Maculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            this.rbMasc.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(77, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Femenino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(154, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Otro";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // labSexo
            // 
            this.labSexo.AutoSize = true;
            this.labSexo.Location = new System.Drawing.Point(82, 108);
            this.labSexo.Name = "labSexo";
            this.labSexo.Size = new System.Drawing.Size(34, 13);
            this.labSexo.TabIndex = 3;
            this.labSexo.Text = "Sexo:";
            this.labSexo.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Perfil Persona";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbMasc);
            this.flowLayoutPanel1.Controls.Add(this.radioButton2);
            this.flowLayoutPanel1.Controls.Add(this.radioButton3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(129, 108);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(217, 29);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // numUpDownEdad
            // 
            this.numUpDownEdad.Location = new System.Drawing.Point(132, 143);
            this.numUpDownEdad.Name = "numUpDownEdad";
            this.numUpDownEdad.Size = new System.Drawing.Size(214, 20);
            this.numUpDownEdad.TabIndex = 3;
            // 
            // labEdad
            // 
            this.labEdad.AutoSize = true;
            this.labEdad.Location = new System.Drawing.Point(81, 145);
            this.labEdad.Name = "labEdad";
            this.labEdad.Size = new System.Drawing.Size(32, 13);
            this.labEdad.TabIndex = 2;
            this.labEdad.Text = "Edad";
            this.labEdad.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Color Favorito";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // gBoxEstCivil
            // 
            this.gBoxEstCivil.Controls.Add(this.cboxViudo);
            this.gBoxEstCivil.Controls.Add(this.cboxCasado);
            this.gBoxEstCivil.Controls.Add(this.ckboxSoltero);
            this.gBoxEstCivil.Location = new System.Drawing.Point(20, 196);
            this.gBoxEstCivil.Name = "gBoxEstCivil";
            this.gBoxEstCivil.Size = new System.Drawing.Size(329, 62);
            this.gBoxEstCivil.TabIndex = 5;
            this.gBoxEstCivil.TabStop = false;
            this.gBoxEstCivil.Text = "Estado Civil";
            // 
            // ckboxSoltero
            // 
            this.ckboxSoltero.AutoSize = true;
            this.ckboxSoltero.Location = new System.Drawing.Point(105, 29);
            this.ckboxSoltero.Name = "ckboxSoltero";
            this.ckboxSoltero.Size = new System.Drawing.Size(59, 17);
            this.ckboxSoltero.TabIndex = 0;
            this.ckboxSoltero.Text = "Soltero";
            this.ckboxSoltero.UseVisualStyleBackColor = true;
            // 
            // cboxCasado
            // 
            this.cboxCasado.AutoSize = true;
            this.cboxCasado.Location = new System.Drawing.Point(195, 29);
            this.cboxCasado.Name = "cboxCasado";
            this.cboxCasado.Size = new System.Drawing.Size(62, 17);
            this.cboxCasado.TabIndex = 1;
            this.cboxCasado.Text = "Casado";
            this.cboxCasado.UseVisualStyleBackColor = true;
            // 
            // cboxViudo
            // 
            this.cboxViudo.AutoSize = true;
            this.cboxViudo.Location = new System.Drawing.Point(274, 29);
            this.cboxViudo.Name = "cboxViudo";
            this.cboxViudo.Size = new System.Drawing.Size(53, 17);
            this.cboxViudo.TabIndex = 2;
            this.cboxViudo.Text = "Viudo";
            this.cboxViudo.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(97, 260);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(252, 101);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(406, 464);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gBoxEstCivil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labEdad);
            this.Controls.Add(this.numUpDownEdad);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labSexo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LabelFNac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.botonAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(422, 503);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownEdad)).EndInit();
            this.gBoxEstCivil.ResumeLayout(false);
            this.gBoxEstCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelFNac;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label labSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numUpDownEdad;
        private System.Windows.Forms.Label labEdad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBoxEstCivil;
        private System.Windows.Forms.CheckBox cboxViudo;
        private System.Windows.Forms.CheckBox cboxCasado;
        private System.Windows.Forms.CheckBox ckboxSoltero;
        private System.Windows.Forms.ListView listView1;
    }
}

