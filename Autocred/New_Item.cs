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
    public partial class New_Item : Form
    {
        public New_Item()
        {
            InitializeComponent();
        }

        private void btn_AddReq_Click(object sender, EventArgs e)
        {
            Form Articulos = new Articulos();
            Articulos.Show();
        }

        private void btn_SaveItem_Click(object sender, EventArgs e)
        {
            if (textbox_Desc == null)
            {
                MessageBox.Show("Debe seleccionar un requerimiento");
                return;
            }
            Int32 CANT;
            if (Int32.TryParse(textBox_Cant.Text, out CANT) == false)
            {
                MessageBox.Show("Debe ingresar una cantidad vàlida");
                return;
            }
        }
    }
}
