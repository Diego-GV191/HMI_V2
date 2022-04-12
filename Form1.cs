using HMI_V2.Componentes;
using HMI_V2.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMI_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Buttons.NavVarDesignButton(ref btnCerrarPrograma, "Right");
            Buttons.NavVarDesignButton(ref btnMinimizar, "Right");
            Buttons.NavVarDesignButton(ref btnConfigVar, "Right", false);
        }

        // Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wPram, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // Minimize borderless form from taskbar
                cp.ClassStyle |= 0x8;
                return cp;
            }
        }

        private void MoverVentana()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private bool FormIsOpen(String NameForm)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == NameForm).SingleOrDefault<Form>();

            if (existe != null)
            {
                MessageBox.Show(existe.Text + " esta abierto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana();
        }

        private void BarraHerramientas_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana();
        }

        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized | this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                ShowInTaskbar = true;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            OpenConfig();
        }

        private void btnConfigVar_Click(object sender, EventArgs e)
        {
            OpenConfig();
        }

        private void OpenConfig()
        {
            if (!FormIsOpen("Config"))
            {
                Config Fconfig = new Config();
                Fconfig.Show();
            }
        }
    }
}
