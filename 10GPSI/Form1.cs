using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10GPSI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            // Captura as teclas de direção
            switch (e.KeyCode)
            {
                case Keys.Up:
                    bloco.Top -= 10;
                    break;
                case Keys.Down:
                    bloco.Top += 10;
                    break;
            }
        }
    }
}
