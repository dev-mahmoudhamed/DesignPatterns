namespace DesignPatterns.DecoratorPattern
{
    public abstract class Text
    {

        public abstract string getText();
        public abstract int getSize();
        public int calculateTextSize(string text)
        {
            return System.Text.ASCIIEncoding.ASCII.GetByteCount(text);
        }
    }
}
