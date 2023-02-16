namespace ModuloINventario
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox4.Enabled= false;
            pictureBox5.Enabled= false;
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            this.Visible=false;
           Form principal= new FrmPrincipal();
            principal.Show();
        }

        private void TbxUsuario_Enter(object sender, EventArgs e)
        {
            if (TbxUsuario.Text == "User")
            {
                TbxUsuario.Text = "";
            }
        }

        private void TbxUsuario_Leave(object sender, EventArgs e)
        {
            if (TbxUsuario.Text == "")
            {
                TbxUsuario.Text = "User";
            }

        }

        private void Tbxpass_Enter(object sender, EventArgs e)
        {
            if (Tbxpass.Text=="Pass")
            {
                Tbxpass.Text = "";
                Tbxpass.UseSystemPasswordChar = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
            }
        }

        private void Tbxpass_Leave(object sender, EventArgs e)
        {
            if (Tbxpass.Text == "")
            {
                Tbxpass.UseSystemPasswordChar = false;
                Tbxpass.Text = "Pass";
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            Tbxpass.UseSystemPasswordChar = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible= false;
            pictureBox5.Visible= true;
            Tbxpass.UseSystemPasswordChar = true;
        }

       

        private void Btnlogin_MouseDown(object sender, MouseEventArgs e)
        {
            Btnlogin.ForeColor = Color.White;
        }
    }
}