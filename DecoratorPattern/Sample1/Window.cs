using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Sample1
{
    public abstract class Window
    {
        private string title;
        protected string Title
        {
            get => title;
            set => title = value;
        }

        public Window()
        {
            title = string.Empty;
        }

        public Window(string _title)
        {
            title = _title;
        }

        public abstract void Render();
    }
}
