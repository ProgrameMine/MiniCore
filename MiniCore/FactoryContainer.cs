using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml;

namespace MiniCore
{
    internal static class FactoryContainer
    {
        public static IFactory factory { get; private set; }
        private static String _buttonType;

        static FactoryContainer()
        {
            _buttonType = "MacButton";
        }

        public static IButton MakeButton()
        {
            return Assembly.Load("MiniCore").CreateInstance("MiniCore." + _buttonType) as IButton;
        }
    }
}
