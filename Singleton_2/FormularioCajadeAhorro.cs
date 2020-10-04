using Singleton_2.BLL;
using Singleton_2.EE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton_2
{
    public partial class FormularioCajadeAhorro : Form
    {
        private CajadeAhorroBLL cajadeAhorroBLL = new CajadeAhorroBLL();
        public FormularioCajadeAhorro()
        {
            InitializeComponent();
            RefrescarGrillaCajadeAhorro();
        }

        private void RefrescarGrillaCajadeAhorro()
        {
            grillaCajadeAhorro.DataSource = null;
            grillaCajadeAhorro.DataSource = cajadeAhorroBLL.ListarCajadeAhorro();
        }

        private void FormularioCajadeAhorro_Load(object sender, EventArgs e)
        {

        }

        private CajadeAhorro ListaCajadeAhorro()
        {
            return new CajadeAhorro
            {
                Codigo = txt_codigo_caja_de_ahorro.Text.Trim(),
                Nombre = txt_nombre_caja_de_ahorro.Text.Trim(),
                Monto = Convert.ToDecimal(txt_monto_caja_de_ahorro.Text.Trim())
            };
        }

        private void btn_alta_caja_de_ahorro_Click(object sender, EventArgs e)
        {
            var cajadeAhorro = ListaCajadeAhorro();
            cajadeAhorroBLL.Alta(cajadeAhorro);
            RefrescarGrillaCajadeAhorro();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txt_codigo_caja_de_ahorro.Text = string.Empty;
            txt_nombre_caja_de_ahorro.Text = string.Empty;
            txt_monto_caja_de_ahorro.Text = string.Empty;
        }

        private CajadeAhorro SeleccionarCajadeAhorro()
        {
            CajadeAhorro cajadeAhorro = grillaCajadeAhorro.SelectedRows[0].DataBoundItem as CajadeAhorro;
            return cajadeAhorro;
        }

        private void btn_baja_caja_de_ahorro_Click(object sender, EventArgs e)
        {
            var cajadeAhorro = SeleccionarCajadeAhorro();
            cajadeAhorroBLL.Baja(cajadeAhorro);
            RefrescarGrillaCajadeAhorro();
            LimpiarCampos();
        }
    }
}
