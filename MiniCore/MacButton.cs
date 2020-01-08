using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCore
{
    internal class MacButton : IButton
    {
        public String Description { get; private set; }

        public MacButton()
        {
            this.Description = " Mac风格按钮";
        }

        public String ShowInfo()
        {
            return this.Description;
        }
    }
}
