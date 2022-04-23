using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using besthelpsystem;

namespace besthelpsystem
{
    public partial class formularioapertura : Form
    {

        public Form formulariohijo;
        

        public formularioapertura()
        {
            InitializeComponent();
            
        }

        public void abrirformulario(Form hija)
        {
            if (formulariohijo != null)
            {
                formulariohijo.Close();
            }
            formulariohijo = hija;
            hija.TopLevel = false;
            hija.FormBorderStyle = FormBorderStyle.None;
            hija.Dock = DockStyle.Fill;
            Pruebaapertura.Controls.Add(hija);
            Pruebaapertura.Tag = hija;
            hija.BringToFront();
            hija.Show();
            
        }


    }
}
