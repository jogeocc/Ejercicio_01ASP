using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesplegarResultado
{
    public partial class DesplegarResp : Form
    {
        public DesplegarResp()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setResultados(decimal[] resultados) {
            TxtSuma.Text = Convert.ToString(resultados[0]);
            TxtResta.Text = Convert.ToString(resultados[1]);
            TxtProd.Text = Convert.ToString(resultados[2]);
            TxtDiv.Text = Convert.ToString(resultados[3]);

        }

    }
}
