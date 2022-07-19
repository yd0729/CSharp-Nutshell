using System.ComponentModel;
using System.Runtime.CompilerServices;

var foo = new Foo();
foo.PropertyChanged += (sender, args) =>
{
    Console.WriteLine(sender);
    Console.WriteLine(args.PropertyName);
};
foo.CustomerName = "asdf";

public class Foo : INotifyPropertyChanged
{
    private string? _customerName;

    public string? CustomerName
    {
        get => _customerName;
        set
        {
            if (value == _customerName) return;
            _customerName = value;
            RaisePropertyChanged();
            // The compiler converts the above line to:
            // RaisePropertyChanged ("CustomerName");
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}