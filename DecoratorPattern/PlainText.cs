namespace DesignPatterns.DecoratorPattern
{
    internal class PlainText : Text
    {
        string _text;
        public PlainText(string text)
        {
            _text = text;
        }
        public override string getText()
        {
            return _text;
        }        
        public override int getSize()
        {
            return calculateTextSize(getText());
        }
    }
}
