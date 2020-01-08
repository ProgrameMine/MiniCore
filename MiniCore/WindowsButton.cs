using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCore
{
    internal class WindowsButton : IButton
    {
        public String Description { get; private set; }

        public WindowsButton()
        {
            this.Description = "Windows风格按钮";
        }

        public String ShowInfo()
        {
            return this.Description;
        }
    }
}
