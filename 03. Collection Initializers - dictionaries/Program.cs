var dict1 = new Dictionary<int, string>()
{
    { 5, "five" },
    { 10, "ten" }
};

// 任何有 indexer 的类型都可以
var dict2 = new Dictionary<int, string>()
{
    [3] = "three",
    [10] = "ten"
};