using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUXSOFTWARE.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnEstaciones_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            PanelBienvenida.Dock = DockStyle.Fill;

        }

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            Personal Person = new Personal();

            Person.Dock = DockStyle.Fill();
           
        }
    }
}
