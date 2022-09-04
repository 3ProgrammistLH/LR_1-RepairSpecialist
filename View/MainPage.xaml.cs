using Kokarev_LR_1.ViewModel;

namespace Kokarev_LR_1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new RepairSpecialistViewModel();
    }
}

