namespace PickerIssues
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            // now lets pick a photo
            PickOptions options = new()
            {
                PickerTitle = "Pick multiple files.... or not?",
                FileTypes = FilePickerFileType.Images
            };

            var fileResult = await FilePicker.Default.PickMultipleAsync(options);

            CounterBtn.Text = $"{fileResult?.Count() ?? 0} files picked";
        }
    }
}