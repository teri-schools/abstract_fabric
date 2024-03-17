
namespace IAbstractFabric{
    public interface IGui
    {
        IButton CreateButton();
        ILabel CreateLabel(string text = "");
        ITextAreal CreateTextAreal(string text = "");
    }

    public interface IButton{
        void click();
    }
    
    public interface ILabel{
        string GetText();
        void SetText(string text);
    }

        
    public interface ITextAreal{
        string GetText();
        void SetText(string text);

        void Input(string input_text);
    }
    
}