using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autocred
{
    public partial class Form_Princ : Form
    {
        public Form_Princ()
        {
            InitializeComponent();
        }

        private void btn_Orden_Click(object sender, EventArgs e)
        {
            Form Lista_Ordenes = new Lista_Ordenes();
            Lista_Ordenes.Show();
        }

        private void btn_Req_Click(object sender, EventArgs e)
        {
            Form Requerimientos = new Requerimientos();
            Requerimientos.Show();
        }

        private void btn_Art_Click(object sender, EventArgs e)
        {
            Form Articulos = new Articulos();
            Articulos.Show();
        }

        private void Form_Princ_Load(object sender, EventArgs e)
        {

        }
    }
}
