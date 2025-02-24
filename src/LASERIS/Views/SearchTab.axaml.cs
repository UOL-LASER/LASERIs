using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LASERIS.Models;
using LASERIS.ViewModels;

namespace LASERIS.Views
{
    public partial class SearchTab : UserControl
    {
        public SearchTab()
        {
            InitializeComponent();
            DataContext = new SearchTabViewModel(); 

            var DataGrid = this.FindControl<DataGrid>("EntryDataGrid");
            if (DataGrid != null) {
                DataGrid.RowEditEnded += OnRowEditEnded;
            }
        }

        private async void OnRowEditEnded(object? sender, DataGridRowEditEndedEventArgs e) {
            if (DataContext is SearchTabViewModel ViewModel && e.Row.DataContext is Entry EditedItem) {
                await ViewModel.UpdateEntryAsync(EditedItem);
            }   
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
