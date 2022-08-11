namespace DesignPatterns.DecoratorPattern
{
    public abstract class Decorator : Text
    {
        private readonly Text _text;
        public Decorator(Text text)
        {
            _text = text;
        }

        public override string getText()
        {
            return _text.getText();
        }
        public int getSize(string text)
        {
            return _text.calculateTextSize(text);
        }

    }
}
