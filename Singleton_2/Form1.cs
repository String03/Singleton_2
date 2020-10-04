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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_caja_de_ahorro_Click(object sender, EventArgs e)
        {
            FormularioCajadeAhorro formularioCajadeAhorro = new FormularioCajadeAhorro();
            formularioCajadeAhorro.Show();
        }

        private void btn_caja_de_ahorro_en_dolares_Click(object sender, EventArgs e)
        {
            FormularioCajadeAhorroenDolares formularioCajadeAhorroenDolares = new FormularioCajadeAhorroenDolares();
            formularioCajadeAhorroenDolares.Show();
        }
    }
}
