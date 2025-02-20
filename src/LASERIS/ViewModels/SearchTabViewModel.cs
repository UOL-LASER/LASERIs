using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Avalonia.Interactivity;
using LASERISAPI.Models;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
namespace LASERIS.ViewModels
{
    public class SearchTabViewModel : BaseViewModel
    {
        private List<Entry> allReturnedEntries = new List<Entry>();
        public ICommand QuerySubmitCommand { get; }
        
        private string? _selectedAttribute;
        public string? SelectedAttribute {
            get => _selectedAttribute;
            set {
                if (_selectedAttribute != value) {
                    _selectedAttribute = value;
                    OnPropertyChanged(nameof(SelectedAttribute));
                }
            }
        }

        private DateTime? _selectedDate;
        public DateTime? SelectedDate {
            get => _selectedDate;
            set {
                if (_selectedDate != value) {
                    _selectedDate = value;
                    OnPropertyChanged(nameof(SelectedDate));
                }
            }
        }

        private string? _selectedQuantity;
        public string? SelectedQuantity {
            get => _selectedQuantity;
            set {
                if (_selectedQuantity != value) {
                    _selectedQuantity = value;
                    OnPropertyChanged(nameof(SelectedQuantity));
                }
            }
        }

        private string? _searchQueryInput;
        public string? SearchQueryInput {
            get => _searchQueryInput;
            set {
                if (_searchQueryInput != value) {
                    _searchQueryInput = value;
                    OnPropertyChanged(nameof(SearchQueryInput));
                }
            }
        }


        public SearchTabViewModel()
        {
            QuerySubmitCommand = new AsyncRelayCommand(OnQuerySubmit);
        }


        private async Task OnQuerySubmit() {
            allReturnedEntries.Clear();
            var queryString = $"{_baseApiUrl}?";

            if (SelectedAttribute != null) {
                if (SelectedAttribute.Equals("ID")) {
                    queryString += $"id={SearchQueryInput}&";
                }
                else if (SelectedAttribute.Equals("Name")) {
                    queryString += $"name={SearchQueryInput}";
                }
                else if (SelectedAttribute.Equals("Manufacturer Name")) {
                    queryString += $"manufacturerName={SearchQueryInput}";
                }
                else if (SelectedAttribute.Equals("Serial Number")) {
                    queryString += $"serialNumber={SearchQueryInput}";
                }
                else if (SelectedAttribute.Equals("Order Code")) {
                    queryString += $"orderCode={SearchQueryInput}";
                }
                else if (SelectedAttribute.Equals("Item Type")) {
                    queryString += $"itemType={SearchQueryInput}";
                }
                else if (SelectedAttribute.Equals("Signed Out To")) {
                    queryString += $"signedOutTo={SearchQueryInput}";
                }
                else if (SelectedAttribute.Equals("Signed Out To ID")) {
                    queryString += $"signedOutToId={SearchQueryInput}";
                }
            }
            if (SelectedDate != null) {
                queryString += $"signedOutDate={SelectedDate.Value.Date:yyyy-MM-dd}&";
            }
            if (SelectedQuantity != null) {
                if (SelectedQuantity == "Zero") {
                    queryString += "quantity=Zero&";
                }
                else if (SelectedQuantity == "One") {
                    queryString += "quantity=One&";
                }
                else if (SelectedQuantity == "More than one") {
                    queryString += "quantity=gt1&";
                }
                else {
                    queryString += $"quantity={SelectedQuantity}&";
                }
            }

            queryString = queryString.TrimEnd('&', '?');

            allReturnedEntries = await _httpClient.GetFromJsonAsync<List<Entry>>(queryString);
        }
    }
}

