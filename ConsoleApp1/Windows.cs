namespace IAbstractFabric.Win32{
    class Button : IAbstractFabric.IButton
    {
        public void click()
        {
            Console.WriteLine("Click is Win Button");
        }
    }

    class Label : IAbstractFabric.ILabel
    {
        private string text = "";

        public Label(string text){
            SetText(text);
        }

        public string GetText()
        {
            return text;
        }

        public void SetText(string text)
        {
            this.text = text;
        }
    }

    class TextAreal : IAbstractFabric.ITextAreal
    {
        private string text = "";

        public TextAreal(string text){
            SetText(text);
        }

        public string GetText()
        {
            return text;
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public void Input(string input_text)
        {
            text += input_text;
        }
    }

    class Gui : IAbstractFabric.IGui
    {
        public IButton CreateButton()
        {
            return new Button();
        }

        public ILabel CreateLabel(string text = "")
        {
            return new Label(text);
        }

        public ITextAreal CreateTextAreal(string text = "")
        {
            return new TextAreal(text);
        }
    }
}