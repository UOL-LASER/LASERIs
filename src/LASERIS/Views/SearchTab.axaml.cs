using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LASERIS.ViewModels;

namespace LASERIS.Views
{
    public partial class SearchTab : UserControl
    {
        public SearchTab()
        {
            InitializeComponent();
            DataContext = new SearchTabViewModel();  
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
