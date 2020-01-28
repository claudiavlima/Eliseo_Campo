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
    public partial class Lista_Ordenes : Form
    {
        public Lista_Ordenes()
        {
            InitializeComponent();
        }

        private void btn_Add_Orden_Click(object sender, EventArgs e)
        {
            Form New_Orden = new New_Orden();
            New_Orden.Show();
        }

        private void Lista_Ordenes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
