namespace IAbstractFabric.Iphone{
    class Button : IAbstractFabric.IButton
    {
        public void click()
        {
            Console.WriteLine("IClick is Iphone IButton");
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
            text += "I" + input_text;
        }
    }

    class Gui : IAbstractFabric.IGui
    {
        public IButton CreateButton()
        {
            return new Button();
        }

        public ILabel CreateLabel(string text = "I")
        {
            return new Label(text);
        }

        public ITextAreal CreateTextAreal(string text = "I")
        {
            return new TextAreal(text);
        }
    }
}