using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio11
{
    public partial class Form1 : Form
    {
        private object txtMensaje1;
        private string mensaje;

        public Form1()
        {
            InitializeComponent();
        }

        private void bntMensaje1_click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty.(txtMensaje1.Text))
            {
                MessageBox.Show("debe completar el campo solicitado")
            }
            else
            {
                string text = bntMensaje1.Text;
                string mensaje = text;
            }

            Form2 f2 = new Form2("");
            f2.mensaje1 = mensaje;
            f2.Show();
        }
    }

    private vold BtnMensaje_Click(object sender, EventArgs e)
    {
        object txtMensaje1 = null;
        if (!string.IsNullOrEmpty.(txtMensaje1.Text))
        {
            MessageBox.Show("debe completar el campo ")
        }
        else
        {
            string text = bntMensaje1.Text;
            string mensaje = text;
        }

        Form2 f2 = new Form2(mensaje);
        string mensaje = null;
        f2.mensaje1 = mensaje;
        f2.Show();
    }
}
