namespace DesignPatterns.DecoratorPattern
{
    public class ToUpperCaseDecorator : Decorator
    {
        public ToUpperCaseDecorator(Text text) : base(text)
        {
        }

        public string getText()
        {
            return (base.getText() + " to Upper").ToUpper();
        }
        public override int getSize()
        {
            return getSize(getText());
        }
    }
}
