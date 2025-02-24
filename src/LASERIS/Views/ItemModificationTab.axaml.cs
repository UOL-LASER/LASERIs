using Avalonia.Controls;
using LASERIS.ViewModels;
using Avalonia.Markup.Xaml;

namespace LASERIS.Views
{
    public partial class ItemModificationTab : UserControl
    {
        public ItemModificationTab()
        {
            InitializeComponent();
            DataContext = new ItemModificationTabViewModel(); 

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
