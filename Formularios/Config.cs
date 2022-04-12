using HMI_V2.Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
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
            Buttons.NavVarDesignButton(ref btnCerrarPrograma, "Right");
            Buttons.NavVarDesignButton(ref btnMinimizar, "Right");
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

        private void Conect1_Click(object sender, EventArgs e)
        {
            Form1 FormPrincipal = new Form1();
            if (Conect1.Text.Equals("Refrescar"))
            {
                Conect1.BackColor = Color.Red;
                // limpieza de PortSerial1
                PortSerial1.Items.Clear();
                BaudRate1.Enabled = true;
                PortSerial1.Enabled = true;
                try
                {
                    // revision de puertos
                    string[] ports = SerialPort.GetPortNames();
                    foreach (string port in ports)
                    {
                        PortSerial1.Items.Add(port);
                    }

                    // seleccion automatica
                    if (PortSerial1.Items.Count >= 0)
                    {
                        PortSerial1.SelectedIndex = 0;
                        Conect1.Text = "Conectar";
                    }
                    else
                    {
                        PortSerial1.Text = "No Serial";
                        Conect1.BackColor = Color.Yellow;
                        Conect1.Text = "Refrescar";
                    }
                }
                catch
                {
                    PortSerial1.Text = "No Serial";
                    PortSerial1.Items.Clear();
                    Conect1.BackColor = Color.Yellow;
                    Conect1.Text = "Refrescar";
                }
            }
            else if  (Conect1.Text.Equals("Conectar"))
            {
                Conect1.BackColor = Color.Lime;
                try
                {
                    // comportamiento
                    FormPrincipal.serialPort1.PortName = PortSerial1.Text;
                    FormPrincipal.serialPort1.BaudRate = Int32.Parse(BaudRate1.Text);
                    FormPrincipal.serialPort1.ReadTimeout = 1000;
                    FormPrincipal.serialPort1.Open();
                    BaudRate1.Enabled = false;
                    PortSerial1.Enabled = false;
                    Conect1.Text = "Desconectar";
                    //ActivarComponentes();
                }
                catch (Exception error)
                {
                    BaudRate1.Enabled = true;
                    PortSerial1.Enabled = true;
                    //DesactivarComponentes();
                    MessageBox.Show(error.Message);
                    PortSerial1.Items.Clear();
                    Conect1.BackColor = Color.Yellow;
                    Conect1.Text = "Refrescar";
                }
            }
            else
            {
                try
                {
                    //DesactivarComponentes();
                    FormPrincipal.serialPort1.Close();
                    PortSerial1.Items.Clear();
                    PortSerial1.Text = "Serial";
                    Conect1.BackColor = Color.Yellow;
                    Conect1.Text = "Refrescar";
                    BaudRate1.Enabled = true;
                    PortSerial1.Enabled = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Conect2_Click(object sender, EventArgs e)
        {
            Form1 FormPrincipal = new Form1();
            if (Conect2.Text.Equals("Refrescar"))
            {
                Conect2.BackColor = Color.Red;
                // limpieza de PortSerial2
                PortSerial2.Items.Clear();
                BaudRate2.Enabled = true;
                PortSerial2.Enabled = true;
                try
                {
                    // revision de puertos
                    string[] ports = SerialPort.GetPortNames();
                    foreach (string port in ports)
                    {
                        PortSerial2.Items.Add(port);
                    }

                    // seleccion automatica
                    if (PortSerial2.Items.Count >= 0)
                    {
                        PortSerial2.SelectedIndex = 0;
                        Conect2.Text = "Conectar";
                    }
                    else
                    {
                        PortSerial2.Text = "No Serial";
                        Conect2.BackColor = Color.Yellow;
                        Conect2.Text = "Refrescar";
                    }
                }
                catch
                {
                    PortSerial2.Text = "No Serial";
                    PortSerial2.Items.Clear();
                    Conect2.BackColor = Color.Yellow;
                    Conect2.Text = "Refrescar";
                }
            }
            else if (Conect2.Text.Equals("Conectar"))
            {
                Conect2.BackColor = Color.Lime;
                try
                {
                    // comportamiento
                    FormPrincipal.serialPort2.PortName = PortSerial2.Text;
                    FormPrincipal.serialPort2.BaudRate = Int32.Parse(BaudRate2.Text);
                    FormPrincipal.serialPort2.ReadTimeout = 1000;
                    FormPrincipal.serialPort2.Open();
                    BaudRate2.Enabled = false;
                    PortSerial2.Enabled = false;
                    Conect2.Text = "Desconectar";
                    //ActivarComponentes();
                }
                catch (Exception error)
                {
                    BaudRate2.Enabled = true;
                    PortSerial2.Enabled = true;
                    //DesactivarComponentes();
                    MessageBox.Show(error.Message);
                    PortSerial2.Items.Clear();
                    Conect2.BackColor = Color.Yellow;
                    Conect2.Text = "Refrescar";
                }
            }
            else
            {
                try
                {
                    //DesactivarComponentes();
                    FormPrincipal.serialPort2.Close();
                    PortSerial2.Items.Clear();
                    PortSerial2.Text = "Serial";
                    Conect2.BackColor = Color.Yellow;
                    Conect2.Text = "Refrescar";
                    BaudRate2.Enabled = true;
                    PortSerial2.Enabled = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Conect3_Click(object sender, EventArgs e)
        {
            Form1 FormPrincipal = new Form1();
            if (Conect3.Text.Equals("Refrescar"))
            {
                Conect3.BackColor = Color.Red;
                // limpieza de PortSerial3
                PortSerial3.Items.Clear();
                BaudRate3.Enabled = true;
                PortSerial3.Enabled = true;
                try
                {
                    // revision de puertos
                    string[] ports = SerialPort.GetPortNames();
                    foreach (string port in ports)
                    {
                        PortSerial3.Items.Add(port);
                    }

                    // seleccion automatica
                    if (PortSerial3.Items.Count >= 0)
                    {
                        PortSerial3.SelectedIndex = 0;
                        Conect3.Text = "Conectar";
                    }
                    else
                    {
                        PortSerial3.Text = "No Serial";
                        Conect3.BackColor = Color.Yellow;
                        Conect3.Text = "Refrescar";
                    }
                }
                catch
                {
                    PortSerial3.Text = "No Serial";
                    PortSerial3.Items.Clear();
                    Conect3.BackColor = Color.Yellow;
                    Conect3.Text = "Refrescar";
                }
            }
            else if (Conect3.Text.Equals("Conectar"))
            {
                Conect3.BackColor = Color.Lime;
                try
                {
                    // comportamiento
                    FormPrincipal.serialPort3.PortName = PortSerial3.Text;
                    FormPrincipal.serialPort3.BaudRate = Int32.Parse(BaudRate3.Text);
                    FormPrincipal.serialPort3.ReadTimeout = 1000;
                    FormPrincipal.serialPort3.Open();
                    BaudRate3.Enabled = false;
                    PortSerial3.Enabled = false;
                    Conect3.Text = "Desconectar";
                    //ActivarComponentes();
                }
                catch (Exception error)
                {
                    BaudRate3.Enabled = true;
                    PortSerial3.Enabled = true;
                    //DesactivarComponentes();
                    MessageBox.Show(error.Message);
                    PortSerial3.Items.Clear();
                    Conect3.BackColor = Color.Yellow;
                    Conect3.Text = "Refrescar";
                }
            }
            else
            {
                try
                {
                    //DesactivarComponentes();
                    FormPrincipal.serialPort3.Close();
                    PortSerial3.Items.Clear();
                    PortSerial3.Text = "Serial";
                    Conect3.BackColor = Color.Yellow;
                    Conect3.Text = "Refrescar";
                    BaudRate3.Enabled = true;
                    PortSerial3.Enabled = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Conect4_Click(object sender, EventArgs e)
        {
            Form1 FormPrincipal = new Form1();
            if (Conect4.Text.Equals("Refrescar"))
            {
                Conect4.BackColor = Color.Red;
                // limpieza de PortSerial4
                PortSerial4.Items.Clear();
                BaudRate4.Enabled = true;
                PortSerial4.Enabled = true;
                try
                {
                    // revision de puertos
                    string[] ports = SerialPort.GetPortNames();
                    foreach (string port in ports)
                    {
                        PortSerial4.Items.Add(port);
                    }

                    // seleccion automatica
                    if (PortSerial4.Items.Count >= 0)
                    {
                        PortSerial4.SelectedIndex = 0;
                        Conect4.Text = "Conectar";
                    }
                    else
                    {
                        PortSerial4.Text = "No Serial";
                        Conect4.BackColor = Color.Yellow;
                        Conect4.Text = "Refrescar";
                    }
                }
                catch
                {
                    PortSerial4.Text = "No Serial";
                    PortSerial4.Items.Clear();
                    Conect4.BackColor = Color.Yellow;
                    Conect4.Text = "Refrescar";
                }
            }
            else if (Conect4.Text.Equals("Conectar"))
            {
                Conect2.BackColor = Color.Lime;
                try
                {
                    // comportamiento
                    FormPrincipal.serialPort4.PortName = PortSerial4.Text;
                    FormPrincipal.serialPort4.BaudRate = Int32.Parse(BaudRate4.Text);
                    FormPrincipal.serialPort4.ReadTimeout = 1000;
                    FormPrincipal.serialPort4.Open();
                    BaudRate4.Enabled = false;
                    PortSerial4.Enabled = false;
                    Conect4.Text = "Desconectar";
                    //ActivarComponentes();
                }
                catch (Exception error)
                {
                    BaudRate4.Enabled = true;
                    PortSerial4.Enabled = true;
                    //DesactivarComponentes();
                    MessageBox.Show(error.Message);
                    PortSerial4.Items.Clear();
                    Conect4.BackColor = Color.Yellow;
                    Conect4.Text = "Refrescar";
                }
            }
            else
            {
                try
                {
                    //DesactivarComponentes();
                    FormPrincipal.serialPort4.Close();
                    PortSerial4.Items.Clear();
                    PortSerial4.Text = "Serial";
                    Conect4.BackColor = Color.Yellow;
                    Conect4.Text = "Refrescar";
                    BaudRate4.Enabled = true;
                    PortSerial4.Enabled = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
