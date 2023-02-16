using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloINventario
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pmenu.Width== 275)
            {
                Pmenu.Width = 0;
            }
            else
            {
                Pmenu.Width = 275;
            }
        }

        private void Btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnProduc_Click(object sender, EventArgs e)
        {
            
            if (Panelkun.Height == 159)
            {
                Panelkun.Height = 0;
            }
            else
            {
                Panelkun.Height = 159;
            }

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Panelkun.Height = 0;
            Panelsan.Height = 0;
            Pnl_bode.Height = 0;
            Pnl_conta.Height = 0;
            Pnl_provee.Height = 0;
        }

        private void Panelsan_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void BtnMovi_Click(object sender, EventArgs e)
        {
            if (Panelsan.Height == 166)
            {
                Panelsan.Height = 0;
            }
            else
            {
                Panelsan.Height = 166;
            }
        }
        public void Abirirpanel (object Formabrir)
        {
            if (this.P_product.Controls.Count>0)
            {
                this.P_product.Controls.RemoveAt(0);

            }
            Form fh = Formabrir as Form;
            fh.TopLevel = false;
            fh.Dock= DockStyle.Fill;
            this.P_product.Controls.Add(fh);
            this.P_product.Tag=fh;
            fh.Show();
        }

        private void P_product_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAgrProd_Click(object sender, EventArgs e)
        {
            Abirirpanel(new Frmproduc());
        }

        
        private void BtnBodega_Click(object sender, EventArgs e)
        {
            if (Pnl_bode.Height == 45)
            {
                Pnl_bode.Height = 0;
            }
            else
            {
                Pnl_bode.Height = 45;
            }
        }

        private void BtnAgrebode_Click(object sender, EventArgs e)
        {
            Abirirpanel(new FrmBodega());
        }

        private void BtnConta_Click(object sender, EventArgs e)
        {
            if (Pnl_conta.Height == 45)
            {
               Pnl_conta.Height = 0;
            }
            else
            {
                Pnl_conta.Height = 45;
            }
        }

        private void BtnProvee_Click(object sender, EventArgs e)
        {
            if (Pnl_provee.Height == 45)
            {
               Pnl_provee.Height = 0;
            }
            else
            {
                Pnl_provee.Height = 45;
            }
        }

        private void BtnAgrePro_Click(object sender, EventArgs e)
        {
            Abirirpanel(new FrmProvee());
        }
    }
}
