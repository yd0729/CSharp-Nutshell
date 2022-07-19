// An enum is a special value type that lets you specify a group of named numeric constants:

BorderSide topSide = BorderSide.Top;
bool isTop = topSide == BorderSide.Top;

public enum BorderSide
{
    Left,
    Right,
    Top,
    Bottom
}

// You may specify an alternative integral type:
public enum BorderSideByte : byte
{
    Left,
    Right,
    Top,
    Bottom
}

// You may also specify an explicit underlying value for each enum member:
public enum BorderSideExplicit : byte
{
    Left = 1,
    Right = 2,
    Top = 10,
    Bottom = 11
}

public enum BorderSidePartiallyExplicit : byte
{
    Left = 1,
    Right,
    Top = 10,
    Bottom
}