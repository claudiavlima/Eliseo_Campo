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
    public partial class Articulos : Form
    {
        Controladora.controladora_Articulos cArticulos;
        public Articulos()
        {
            InitializeComponent();
            cArticulos = Controladora.controladora_Articulos.obtener_instancia();
            ARMA_GRILLA();
        }
                
     
        public void ARMA_GRILLA()
        {
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = cArticulos.Listar_Articulos();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
