using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgregarDatos
{
    public partial class AgregarDatos : Form
    {
        decimal[] numeros = new decimal[3];
        Int16 cuantos=3,contador=0;

        public AgregarDatos()
        {
            InitializeComponent();
            BtnRegresar.Enabled = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           

            if (TxtNum.Text != "")
            {

                numeros[contador] = Convert.ToDecimal(TxtNum.Text);
                contador++;
                TxtNum.Focus();

            }

            if (contador == cuantos)
            {
                Letrero.Mensaje objMen = new Letrero.Mensaje();
                TxtNum.Enabled = false;
                BtnRegresar.Enabled = true;
                objMen.setLetrero("Ya ingresó los 3 números");
                objMen.ShowDialog();
            }
            else {

                LblNum.Text = "Ingrese el Número " + (contador + 1);
                TxtNum.Text = "";

            }
            
           

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Inicio.Inicio objInicio = new Inicio.Inicio();
            objInicio.setDato(numeros,cuantos);
            objInicio.Show();
           

            this.Close();
        }
    }
}
