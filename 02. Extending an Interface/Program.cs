// We can extend interfaces - just like extending classes:

IRedoable r = null;
IUndoable u = r;

public interface IUndoable { void Undo(); }
public interface IRedoable : IUndoable { void Redo(); }