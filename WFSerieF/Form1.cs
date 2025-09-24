using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerieFigonnaci;

namespace WFSerieF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNum.Text))
            {
                TxtResultado.Clear();
                SerieFigonnaci.SerieF ser = new SerieFigonnaci.SerieF();
                ser.Setnum1(int.Parse(TxtNum.Text));
                int[] serie = ser.serieFigo();
                string resultado = string.Join(", ", serie);
                TxtResultado.Text = resultado;
                TxtNum.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un numero");
            }
        }
    }
}
