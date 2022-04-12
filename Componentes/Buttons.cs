using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HMI_V2.Componentes
{
    internal class Buttons
    {
        public static void NavVarDesignButton(ref Button btn, string Lado, bool Visible = true)
        {
            btn.BackColor = Color.FromArgb(150, 150, 255);
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Visible = Visible;

            if (Lado.Equals("Left")) btn.Dock = DockStyle.Left;
            if (Lado.Equals("Right")) btn.Dock = DockStyle.Right;
        }
    }
}