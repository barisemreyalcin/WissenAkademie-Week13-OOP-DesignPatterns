using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Sample1
{
    public class ThemaDecorator : WindowDecorator
    {
        public ThemaDecorator(Window window,string title):base(window,title) { }

        public override void Render()
        {
            TargetWindow.Render();
        }

        public void SetTheme(string name)
        {
            Console.WriteLine($"{name} başlıklı pencere {Title} teması ile uygulandı");
            Render();
        }
    }
}
