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
    public partial class FormularioCajadeAhorroenDolares : Form
    {
        private CajadeAhorroenDolaresBLL cajadeAhorroenDolaresBLL = new CajadeAhorroenDolaresBLL();
        public FormularioCajadeAhorroenDolares()
        {
            InitializeComponent();
            RefrescarGrillaCajadeAhorroenDolares();
        }

        private void RefrescarGrillaCajadeAhorroenDolares()
        {
            grillaCajadeAhorroenDolares.DataSource = null;
            grillaCajadeAhorroenDolares.DataSource = cajadeAhorroenDolaresBLL.ListarCajadeAhorroenDolares();
        }

        private CajadeAhorroenDolares ListarCajadeAhorroenDolares()
        {
            return new CajadeAhorroenDolares
            {
                Codigo = txt_codigo_caja_de_ahorro_en_dolares.Text.Trim(),
                Nombre = txt_nombre_caja_de_ahorro_en_dolares.Text.Trim(),
                Monto = Convert.ToDecimal(txt_monto_caja_de_ahorro_en_dolares.Text.Trim())
            };
        }

        private void btn_alta_caja_de_ahorro_en_dolares_Click(object sender, EventArgs e)
        {
            var cajadeAhorroenDolares = ListarCajadeAhorroenDolares();
            cajadeAhorroenDolaresBLL.Alta(cajadeAhorroenDolares);
            RefrescarGrillaCajadeAhorroenDolares();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txt_codigo_caja_de_ahorro_en_dolares.Text = string.Empty;
            txt_nombre_caja_de_ahorro_en_dolares.Text = string.Empty;
            txt_monto_caja_de_ahorro_en_dolares.Text = string.Empty;
        }

        private void FormularioCajadeAhorroenDolares_Load(object sender, EventArgs e)
        {

        }
    }
}
