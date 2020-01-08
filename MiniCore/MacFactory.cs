using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCore
{
    internal sealed class MacFactory : IFactory
    {
        public IButton MakeButton()
        {
            return new MacButton();
        }
    }
}
