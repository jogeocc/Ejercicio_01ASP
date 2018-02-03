using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class Inicio : Form
    {

        Int16 opcion,cuantos;
        Letrero.Mensaje Mensaje = new Letrero.Mensaje();
        AgregarDatos.AgregarDatos objAgregarDat = new AgregarDatos.AgregarDatos();
        decimal[] numeros,resultados= {0,0,0,0};


        public Inicio()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void setDato(decimal[] numeros,Int16 cuantos) {

           this.numeros= numeros;
           this.cuantos = cuantos;

        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {

            try
            {
                opcion = Convert.ToInt16(TxtOpcion.Text);
            }
            catch (Exception exception) {

             
            }


           
                switch (opcion) {
                    case 1:
                            this.Hide();
                             objAgregarDat.Show();
                    break;
                    case 2:
                        resultados[0]=realizarSuma(numeros);
                        Mensaje.setLetrero("Suma Realizada");
                        Mensaje.ShowDialog();
                        break;
                    case 3:
                        resultados[1] = realizarResta(numeros);
                        Mensaje.setLetrero("Resta Realizada");
                        Mensaje.ShowDialog();
                    break;
                    case 4:
                        resultados[2] = realizarProducto(numeros);
                        Mensaje.setLetrero("Producto Realizado");
                        Mensaje.ShowDialog();
                    break;
                    case 5:
                        resultados[3] = realizarDiv(numeros);
                        Mensaje.setLetrero("División Realizada");
                        Mensaje.ShowDialog();
                    break;
                    case 6:
                        DesplegarResultado.DesplegarResp objDespRel = new DesplegarResultado.DesplegarResp();
                        objDespRel.setResultados(resultados);
                        objDespRel.ShowDialog();
                    break;
                  default:
                        Mensaje.setLetrero("Opción no valida");
                        Mensaje.ShowDialog();
                    break;

                } 
        }

        public decimal realizarSuma(decimal[] numeros) {
            decimal resp = numeros[0];
            for (Int16 i = 1; i < cuantos; i++) {

                resp += numeros[i];

            }

            return resp;
        }

        public decimal realizarResta(decimal[] numeros)
        {
            decimal resp = numeros[0];
            for (Int16 i = 1; i < cuantos; i++)
            {

                resp -= numeros[i];

            }

            return resp;
        }

        public decimal realizarProducto(decimal[] numeros)
        {
            decimal resp = numeros[0];
            for (Int16 i = 1; i < cuantos; i++)
            {

                resp *= numeros[i];

            }

            return resp;
        }

        public decimal realizarDiv(decimal[] numeros)
        {
            decimal resp = numeros[0];
            for (Int16 i = 1; i < cuantos; i++)
            {

                resp /= numeros[i];

            }

            return resp;
        }

    }
}
