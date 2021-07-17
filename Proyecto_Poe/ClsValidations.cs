using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Poe
{
    public class ClsValidations
    {
        public void Only_Numbers(object a, KeyPressEventArgs b)
        {
            if (!char.IsNumber(b.KeyChar) && b.KeyChar != Convert.ToChar(Keys.Back))
            {
                b.Handled = true;
                return;
            }
        }

        public void Only_Letters(object a, KeyPressEventArgs b)
        {
            if (!char.IsLetter(b.KeyChar) && b.KeyChar != Convert.ToChar(Keys.Back)
               && b.KeyChar != Convert.ToChar(Keys.Space))
            {
                b.Handled = true;
                return;
            }
        }
    }
}
