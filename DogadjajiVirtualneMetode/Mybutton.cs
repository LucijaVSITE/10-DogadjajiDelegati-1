using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vsite.CSharp
{
    class Mybutton : System.Windows.Forms.Button
    {
        protected override void OnClick(EventArgs e)
        {
            MessageBox.Show("Kliknuo si me!", "Moj button");
            //base.OnClick(e); izbjeći generiranje novih akcija
        }
    }
}
