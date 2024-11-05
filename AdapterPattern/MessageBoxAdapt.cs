using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class MessageBoxAdapt
    {
        //windows form üyesi olan Message Box özelliğini uyumlu hale getireceğiz.
        [DllImport("user32.dll", EntryPoint = "MessageBox", CallingConvention = CallingConvention.Winapi)]
        public static extern int MessageBox(IntPtr hWind, string text, string caption, uint button);

        public void alert(string title,string message, Buttons combinations)
        {
            MessageBox(new IntPtr(), message, title, (uint)combinations);
        }
    }
}
