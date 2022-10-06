using RepoBackButtonBehavior.Viewmodels;

namespace RepoBackButtonBehavior;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }
}