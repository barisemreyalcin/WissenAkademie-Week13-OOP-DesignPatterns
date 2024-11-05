using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Sample1
{
    public class ReportWindow : Window
    {
        public ReportWindow() { }

        public ReportWindow(string title):base(title) { }
        public override void Render()
        {
            Console.WriteLine($"{Title} Başlıklı Rapor Ekranı render edildi....");
        }
    }
}
