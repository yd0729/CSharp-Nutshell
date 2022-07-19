RichTextBox r = new RichTextBox();
// r.Undo();                       // Compilation Error Undo 是 protected 的
((IUndoable)r).Undo(); // RichTextBox.Undo  只有 TextBox 实现了接口，但 Undo 是 virtual 的
// ((TextBox)r).Undo();            // Compilation Error Undo 是 protected 的

public interface IUndoable
{
    void Undo();
}

// 这种方法适用于想要显式实现接口（只能通过接口的引用调用接口的方法）
// 但仍然希望子类能够重写逻辑（Undo 是 protected 的，不能在外部使用）

public class TextBox : IUndoable
{
    void IUndoable.Undo() => Undo();
    protected virtual void Undo() => Console.WriteLine("TextBox.Undo");
}

public class RichTextBox : TextBox
{
    protected override void Undo() => Console.WriteLine("RichTextBox.Undo");
}

// 总结（practice）
// 1. 隐式实现最好是 virtual 的
// 2. 显示实现使用上面的方式