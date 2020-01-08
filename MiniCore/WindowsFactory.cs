using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCore
{
    internal sealed class WindowsFactory : IFactory
    {
        public IButton MakeButton()
        {
            return new WindowsButton();
        }
    }
}
