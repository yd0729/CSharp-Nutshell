RichTextBox r = new RichTextBox();
r.Undo(); // RichTextBox.Undo 
((IUndoable)r).Undo(); // TextBox.Undo  只有 TextBox 显式实现了接口
// ((TextBox)r).Undo();            // compilation error 显式实现的接口只能由接口的引用调用

public interface IUndoable
{
    void Undo();
}

public class TextBox : IUndoable
{
    void IUndoable.Undo() => Console.WriteLine("TextBox.Undo");
}

public class RichTextBox : TextBox
{
    public void Undo() => Console.WriteLine("RichTextBox.Undo");
}