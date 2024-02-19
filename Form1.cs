using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasDatosSimples
{
    public partial class Form1 : Form
    {
        //Listas            
        //List <tipodato> nombrelista = new List<tipodato>();
        List<int> listaEnteros = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            //Opcion 1
            //listaEnteros.Add(Convert.ToInt32(textBoxNumero.Text));
            //opcion 2
            int numero = Convert.ToInt32(textBoxNumero.Text);
            listaEnteros.Add(numero);
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            //Opción 1: Manual
            /*for (int i = 0; i < listaEnteros.Count; i++)
            {
                listBoxDemostrar.Items.Add(listaEnteros[i]);
            }*/

            Mostrar();
        }
        private void Mostrar()
        {
            //Opción 2: Automatico
            //Funciona con: combox, istbox, datagridview
            listBoxMostrar.DataSource = null;
            listBoxMostrar.Refresh();
            listBoxMostrar.DataSource = listaEnteros;
            textBoxNumero.Text = "";
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            //lo ordena internamente de menor a mayor
            listaEnteros.Sort();
            Mostrar();
        }

        private void buttonDescendente_Click(object sender, EventArgs e)
        {
            //primero hay que ordenaro de forma ascendente y ya luego darle la vuelta a la lista
            listaEnteros.Sort();
            listaEnteros.Reverse();
            Mostrar();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int numero = 0; 
            bool seConvirtio = int.TryParse(textBoxNumero.Text, out numero);
            if(seConvirtio ) 
            {
                listaEnteros.Remove(numero);
                Mostrar();
            }
            else
            {
                MessageBox.Show("Debe Ingresar un número");
            }
        }
    }
}
