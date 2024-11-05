using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Sample1
{
    public class LoginWindow : Window
    {
        public LoginWindow()
        { 
        
        }

        public LoginWindow(string title):base(title)
        {

        }
        public override void Render()
        {
            Console.WriteLine($"{Title} Başlıklı Login Ekranı render edildi....");
        }
    }
}
