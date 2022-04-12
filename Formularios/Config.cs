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

namespace HMI_V2.Formularios
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
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

        private void Config_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana();
        }

        private void BarraHerramientas_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana();
        }

        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
