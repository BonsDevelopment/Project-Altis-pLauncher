using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Altis_pLauncher.Custom_Controls
{
    class TransparentTextBox : RichTextBox
    {
        public TransparentTextBox()
        {

            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.ScrollBars = RichTextBoxScrollBars.None;
            this.AcceptsTab = false;
            this.Multiline = false;
        }


        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            //Don't draw the background here.
            return;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; //WS_EX_TRANSPARENT
                return cp;
            }
        }
    }
}
