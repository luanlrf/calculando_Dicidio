using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomiDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salario, dicidio, calculo, valordicidio,valorpercent;
            salario = double.Parse(tsalario.Text);
            dicidio = double.Parse(tdicidio.Text);
            valordicidio = dicidio*salario;
            calculo = valordicidio + salario;
            tcalculo.Text = calculo.ToString();
        }
    }
}
