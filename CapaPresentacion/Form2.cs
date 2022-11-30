using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSNormal_Click(object sender, EventArgs e)
        {
            using (ServicioNormal Productoss1 = new ServicioNormal())
                Productoss1.ShowDialog();
        }

        private void btnSEspecial_Click(object sender, EventArgs e)
        {
            using (ServicioEspecial Productoss2 = new ServicioEspecial())
                Productoss2.ShowDialog();
        }
    }
}
