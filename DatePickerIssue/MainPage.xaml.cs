using CommunityToolkit.Mvvm.ComponentModel;

namespace DatePickerIssue;

public partial class MainPage
{
	public MainPage()
	{
		BindingContext = new MainPageViewModel();
		InitializeComponent();
	}
}

public partial class MainPageViewModel : ObservableObject
{
	[ObservableProperty]
	private DateTime _date = DateTime.Now;
	
	[ObservableProperty]
	private DateTime _dateMax = DateTime.Now + TimeSpan.FromDays(60);
	
	[ObservableProperty]
	private DateTime _dateMin = DateTime.Now - TimeSpan.FromDays(60);
	
}