namespace Program{

    static class Client{
        static void DemoGui(IAbstractFabric.IGui guiFactory){
            // Create a button
            IAbstractFabric.IButton button = guiFactory.CreateButton();
            button.click();

            // Create a label with default text
            IAbstractFabric.ILabel label = guiFactory.CreateLabel();
            Console.WriteLine("Label text: " + label.GetText());

            // Create a text area with specified text
            IAbstractFabric.ITextAreal textArea = guiFactory.CreateTextAreal("Initial Text");
            Console.WriteLine("Text Area text: " + textArea.GetText());

            // Set new text for label and text area
            label.SetText("New Label Text");
            textArea.SetText("New Text Area Text");

            // Display the updated text
            Console.WriteLine("Updated Label text: " + label.GetText());
            Console.WriteLine("Updated Text Area text: " + textArea.GetText());
        
        }

        static void Main(){
            Console.WriteLine("\n\nWin:\n");
            DemoGui(new IAbstractFabric.Win32.Gui());
            Console.WriteLine("\n\nIphone:\n");
            DemoGui(new IAbstractFabric.Iphone.Gui());
        }
    }
}