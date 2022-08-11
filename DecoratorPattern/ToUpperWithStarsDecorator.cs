using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public class ToUpperWithStarsDecorator : Decorator
    {
        public ToUpperWithStarsDecorator(Text text) : base(text)
        {
        }

        public string getText()
        {
            return ("******" + base.getText() + " to lower + ****").ToUpper();
        }
        public override int getSize()
        {
            return getSize(getText());
        }
    }
}
