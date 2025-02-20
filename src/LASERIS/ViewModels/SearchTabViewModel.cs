using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Avalonia.Interactivity;
using LASERISAPI.Models;

namespace LASERIS.ViewModels
{
    public class SearchTabViewModel : BaseViewModel
    {
        private List<Entry> allReturnedEntries = new List<Entry>();

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

        private async Task OnQuerySubmit(object sender, RoutedEventArgs e) {
            allReturnedEntries.Clear();
            var queryString = $"{_baseApiUrl}?";

            if (SelectedAttribute != null) {
                queryString += $"attribute={SelectedAttribute}&";
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

