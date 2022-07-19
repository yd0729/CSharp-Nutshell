RichTextBox r = new RichTextBox();

r.Undo(); // RichTextBox.Undo
((IUndoable)r).Undo(); // RichTextBox.Undo 虽然接口实现不是 virtual 的，但是 TextBox 和 RichTextBox 都各自实现了接口
((TextBox)r).Undo(); // TextBox.Undo 这个方法不是 virtual 的

public interface IUndoable
{
    void Undo();
}

public class TextBox : IUndoable
{
    public void Undo() => Console.WriteLine("TextBox.Undo");
}

// RichBox reimplements IUndoable
// 应该避免在 subclass 中 reimplement
public class RichTextBox : TextBox, IUndoable
{
    public new void Undo() => Console.WriteLine("RichTextBox.Undo");
}