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
                if(_selectedAttribute != value) {
                    _selectedAttribute = value;
                    OnPropertyChanged(nameof(SelectedAttribute));
                }
            }
        }

        private DateTime? _selectedDate;
        public DateTime? SelectedDate {
            get => _selectedDate;
            set {
                if(_selectedDate != value) {
                    _selectedDate = value;
                    OnPropertyChanged(nameof(SelectedDate));
                }
            }
        }

        private string? _selectedQuantity;
        public string? SelectedQuantity {
            get => _selectedQuantity;
            set {
                if(_selectedQuantity != value) {
                    _selectedQuantity = value;
                    OnPropertyChanged(nameof(SelectedQuantity));
                }
            }
        }

        private string? _searchQueryInput;
        public string? SearchQueryInput {
            get => _searchQueryInput;
            set {
                if(_searchQueryInput != value) {
                    _searchQueryInput = value;
                    OnPropertyChanged(nameof(SearchQueryInput));
                }
            }
        }

        private async Task OnQuerySubmit(object sender, RoutedEventArgs e) {
            if(SelectedAttribute != null) {
                List<Entry> returnedEntries = await _httpClient.GetFromJsonAsync<List<Entry>>(_baseApiUrl + "");
                AddEntries(returnedEntries);
            }
            if(SelectedDate != null) {
                List<Entry> returnedEntries = await _httpClient.GetFromJsonAsync<List<Entry>>(_baseApiUrl + "");
                AddEntries(returnedEntries);
            }
            if(SelectedQuantity != null) {
                List<Entry> returnedEntries = new List<Entry>();

                if(SelectedQuantity == "Zero") {returnedEntries = await _httpClient.GetFromJsonAsync<List<Entry>>(_baseApiUrl + "");}
                else if(SelectedQuantity == "One") {returnedEntries = await _httpClient.GetFromJsonAsync<List<Entry>>(_baseApiUrl + "");}
                else if(SelectedQuantity == "More than one") {
                    // Query for all, then filter out entries with 0 or 1. Add directly to allReturnedEntries.
                    returnedEntries = await _httpClient.GetFromJsonAsync<List<Entry>>(_baseApiUrl + "");
                    foreach(Entry entry in returnedEntries) {
                        if(!(entry.quantity == 0 || entry.quantity == 1)) {
                            allReturnedEntries.Add(entry);
                        }
                    }
                    return;
                }

                AddEntries(returnedEntries);
            }
            
            foreach(Entry entry in allReturnedEntries) {
                if((entry.signedOutDate.Equals(SelectedDate.Value.Date))) {

                }
            }
        }
        

        private void AddEntries(List<Entry> returnedEntries) {
            if(returnedEntries != null) {
                foreach(Entry entry in returnedEntries) {
                    allReturnedEntries.Add(i);
                }
            }
        }
    }
}

