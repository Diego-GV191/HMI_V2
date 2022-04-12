using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMI_V2.Controles
{
    internal class Controls
    {
        public static void ControlDesingForm(ref EllipseControls EControl)
        {
            EControl.BackColor = Color.FromArgb(150, 150, 255);
            EControl.CornerRadius = 70;
        }
    }
}
