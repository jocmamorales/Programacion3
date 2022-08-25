using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class FormFecha : Form
    {
        public FormFecha()
        {
            InitializeComponent();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            DateTime fecha1;
            fecha1 = dtpFecha.Value;

            MessageBox.Show("La fecha seleccionada es: " + dtpFecha.Value.ToString("ddd/mm/yyy"));
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha seleccionada es: " + CalFecha.SelectionStart);
        }
    }
}
