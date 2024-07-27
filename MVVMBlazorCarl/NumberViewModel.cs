using System.ComponentModel;

namespace MVVMBlazorCarl;

public class NumberViewModel : ObservableObject
{

    private int number = 42;

    public int Number
    {
        get => number;
        set => SetProperty(ref number, value);

    }
}
