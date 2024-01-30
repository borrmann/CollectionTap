namespace CollectionTap
{
    public partial class MainPage : ContentPage
    {
        private readonly MyPageViewModel _vm;
        public MainPage(MyPageViewModel vm)
        {
            InitializeComponent();
            _vm = vm;
            BindingContext = _vm;
        }

        protected override async void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
            await _vm.FetchDataAsync();
        }

    }

}
