using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LASERIS.Views
{
    public partial class SearchTab : UserControl
    {
        public SearchTab()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
