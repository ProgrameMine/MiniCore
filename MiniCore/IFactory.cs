using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCore
{
    internal interface IFactory
    {
        IButton MakeButton();
    }
}
