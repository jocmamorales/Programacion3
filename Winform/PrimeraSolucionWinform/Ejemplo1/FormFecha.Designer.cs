namespace Ejemplo1
{
    partial class FormFecha
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnFecha = new System.Windows.Forms.Button();
            this.CalFecha = new System.Windows.Forms.MonthCalendar();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(184, 77);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(501, 73);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(75, 23);
            this.btnFecha.TabIndex = 1;
            this.btnFecha.Text = "Prueba 1";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // CalFecha
            // 
            this.CalFecha.Location = new System.Drawing.Point(174, 148);
            this.CalFecha.Name = "CalFecha";
            this.CalFecha.TabIndex = 2;
            // 
            // btnCalendar
            // 
            this.btnCalendar.Location = new System.Drawing.Point(518, 166);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(75, 23);
            this.btnCalendar.TabIndex = 3;
            this.btnCalendar.Text = "Prueba2";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // FormFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.CalFecha);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.dtpFecha);
            this.Name = "FormFecha";
            this.Text = "FormFecha";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.MonthCalendar CalFecha;
        private System.Windows.Forms.Button btnCalendar;
    }
}