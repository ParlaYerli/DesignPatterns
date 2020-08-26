using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Example2
{
    public interface ICarDecorator
    {
        void PrintDetail();
        void AddPrice(decimal addedPrice);
        void AddDescription(string addedDesc);
    }
}
