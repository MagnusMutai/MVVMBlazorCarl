using System.ComponentModel;

namespace MVVMBlazorCarl;

public class NumberViewModel : INotifyPropertyChanged/*ObservableObject*/
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private int number = 42;

    public int Number
    {
        get => number; 
        set
        {
            if (number != value)
            {
                number = value;
                this.Notify(PropertyChanged);
            }
        }
    }
    //private int number = 42;

    //public int Number
    //{
    //    get => number;
    //    set => SetProperty(ref number, value);

    //}
}
