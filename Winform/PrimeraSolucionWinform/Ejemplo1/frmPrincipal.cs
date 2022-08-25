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
    public partial class frmVPrincipal : Form
    {
        public frmVPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void ArchivotoolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1)) //COMPARO OBJETO
                    return;
            }

            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void frmVPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
