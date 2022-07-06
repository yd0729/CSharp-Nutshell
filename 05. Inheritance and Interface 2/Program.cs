RichTextBox r = new RichTextBox();

r.Undo();                 // RichTextBox.Undo
((IUndoable)r).Undo();    // TextBox.Undo 只有 TextBox 实现了接口，且接口实现不是 virtual 的．
((TextBox)r).Undo();      // TextBox.Undo 这个方法不是 virtual 的．

public interface IUndoable { void Undo(); }

public class TextBox : IUndoable
{
    public void Undo() => Console.WriteLine ("TextBox.Undo");
}

// RichTextBox 继承了 Undo ，但不被认为实现了 IUndoable ．
public class RichTextBox : TextBox
{
    public new void Undo() => Console.WriteLine ("RichTextBox.Undo");
}