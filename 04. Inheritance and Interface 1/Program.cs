RichTextBox r = new RichTextBox();
r.Undo(); // RichTextBox.Undo
((IUndoable)r).Undo(); // RichTextBox.Undo  只有 TextBox 实现了接口，但接口实现是 virtual 的
((TextBox)r).Undo(); // RichTextBox.Undo  这个方法是 virtual 的

public interface IUndoable
{
    void Undo();
}

public class TextBox : IUndoable
{
    public virtual void Undo() => Console.WriteLine("TextBox.Undo");
}

// RichTextBox 继承了 Undo ，但不被认为实现了 IUndoable ．
// ((IUndoable)r).Undo() 能够调用 RichTextBox.Undo ，是因为 Undo 是 virtual 的
public class RichTextBox : TextBox
{
    public override void Undo() => Console.WriteLine("RichTextBox.Undo");
}