using componentesBA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace componentes
{
    public partial class frmcomponentes : Form
    {


        private componentesBA.componentes componente = new componentesBA.componentes();



        public frmcomponentes()
        {
            InitializeComponent();
            DGV.DataSource = componente.lista;
        }

        private void frmcomponentes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            componente componente = new componente(0,txtnombre.Text,
                                                   txtcapacidad.Text,
                                                   txttipo.Text ,
                                                   txtvelocidad.Text);

            this.componente.insert(componente);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            componente.Borrar(Convert.ToInt32(DGV.CurrentRow.Cells[0].Value));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            componente update_componente = new componente(Convert.ToInt32(DGV.CurrentRow.Cells[0].Value),
                txtnombre.Text,txtcapacidad.Text,txttipo.Text,txtvelocidad.Text);
            this.componente.Update(update_componente);

        }

        private void DGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtnombre.Text = DGV.CurrentRow.Cells[1].Value.ToString();
            txtcapacidad.Text = DGV.CurrentRow.Cells[2].Value.ToString();
            txttipo.Text = DGV.CurrentRow.Cells[3].Value.ToString();
            txtvelocidad.Text = DGV.CurrentRow.Cells[4].Value.ToString();
        }
    }



}



