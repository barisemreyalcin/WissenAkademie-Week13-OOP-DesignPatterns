using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Sample1
{
    public abstract class WindowDecorator : Window
    {
        private Window targetWindow;
        public Window TargetWindow
        {
            get => targetWindow;
            set=> targetWindow = value;
        }

        public WindowDecorator(Window _window,string _title)
        {
            targetWindow = _window;
            Title = _title;
        }

        public override void Render()
        {
            throw new NotImplementedException();
        }
    }
}
