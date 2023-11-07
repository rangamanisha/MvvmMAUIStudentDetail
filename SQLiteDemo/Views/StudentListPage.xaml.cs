using SQLiteDemo.ViewModels;

namespace SQLiteDemo.Views;

public partial class StudentListPage : ContentPage
{
	public StudentListPage(StudentListPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}