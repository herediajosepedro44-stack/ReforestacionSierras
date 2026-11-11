using ReforestacionSierras.BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Se desarrollo una aplicacion para indicar en que lugares y en que fecha se plantaron plantines de
//arboles autoctones de la provincia de cordoba, ya que es necesario saber si ciertas zonas de
//las sierras estan recuperando su flora luego de los incendios.

namespace ReforestacionSierras.FE
{
    public partial class Form1 : Form
    {
        Arboles ListaArboles = new Arboles();

        public Form1()
        {
            InitializeComponent();
            dg.DataSource = ListaArboles.ListaDT;
        }

        private void BtAceptar_Click_1(object sender, EventArgs e)
        {
            Arbol arb = new Arbol();
            arb.Agregar(txtEspecie.Text,
                        txtZona.Text,
                        txtFecha.Text);

            ListaArboles.InsertArbol(arb);
            txtId.Text = arb.Id.ToString();
        }

        private void BtBuscar_Click_1(object sender, EventArgs e)
        {
            Arbol arbF = ListaArboles.Buscar(txtId.Text);

            if (arbF.Id != 0)
            {
                txtEspecie.Text = arbF.Especie;
                txtZona.Text = arbF.Zona;
                txtFecha.Text = arbF.Fecha;

                txtEspecie.Focus();
            }
            else
            {
                txtId.Text = "No Existe";
                txtId.SelectAll();
                txtId.Focus();
            }
        }

        
    }
}
