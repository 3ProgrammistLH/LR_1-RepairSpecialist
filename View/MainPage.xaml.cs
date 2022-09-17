using Kokarev_LR_1.ViewModel;

namespace Kokarev_LR_1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new RepairSpecialistViewModel();

    }

    private void CollectionView_ScrollToRequested(object sender, ScrollToRequestEventArgs e)
    {

    }

    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {

    }
}

