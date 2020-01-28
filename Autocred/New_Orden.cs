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
    public partial class New_Orden : Form
    {
        public New_Orden()
        {
            InitializeComponent();
        }

        private void New_Orden_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        DateTime hoy = DateTime.Now;
        private void button1_Click(object sender, EventArgs e)
        {
            Form Proveedores = new Proveedores();
            Proveedores.Show();
            Fecha.Text = hoy.ToShortDateString();
        }

        private void Add_Item_Click(object sender, EventArgs e)
        {
            Form New_Item = new New_Item();
            New_Item.Show();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listo Orden Guardada");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
