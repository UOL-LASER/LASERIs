using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Input;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Avalonia.Interactivity;
using LASERIS.Models;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
namespace LASERIS.ViewModels
{
    public class SearchTabViewModel : BaseViewModel
    {
        private List<Entry> AllReturnedEntries = new List<Entry>();
        public ObservableCollection<Entry> ReturnedEntries { get;}

        public List<string> SelectableAttributes {get;}
        public List<string> SelectableQuantity {get;}

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

        private String? _selectedDate;
        public String? SelectedDate {
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
            ReturnedEntries = new ObservableCollection<Entry>();
            
            SelectableAttributes = new() { "ID", "Name", "Manufacturer Name", "Serial Number", "Order Code", "Item Type", "Signed Out To", "Signed Out To ID"};
            SelectableQuantity = new() {"Zero", "One", "More than one"};

        }


        private async Task OnQuerySubmit() {
            ReturnedEntries.Clear();
            AllReturnedEntries.Clear();
            var queryString = $"{_baseApiUrl}entries?";

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
                queryString += $"signedOutDate={DateTime.ParseExact(SelectedDate, "dd-MM-yyyy", CultureInfo.InvariantCulture)}&";
            }
            if (SelectedQuantity != null) {
                if (SelectedQuantity == "Zero") {
                    queryString += "quantity=0&";
                }
                else if (SelectedQuantity == "One") {
                    queryString += "quantity=1&";
                }
                else if (SelectedQuantity == "More than one") {
                    queryString += $"quantity={Uri.EscapeDataString(">1")}&";
                }
            }

            queryString = queryString.TrimEnd('&', '?');

            try {
                AllReturnedEntries = await _httpClient.GetFromJsonAsync<List<Entry>>(queryString);
            }
            catch (Exception ex) {
                System.Console.WriteLine($"Error contacting API: {ex.Message}");
            }

            foreach (Entry entry in AllReturnedEntries) {
                ReturnedEntries.Add(entry);
            }
        }

        public async Task UpdateEntryAsync(Entry item) {
            try {
                HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"{_baseApiUrl}entry/{item.id}", item);

                if (response.IsSuccessStatusCode) {
                    System.Console.WriteLine("Update successful");
                }
                else {
                    System.Console.WriteLine($"Update failed: {response.StatusCode}");
                }
            }
            catch (Exception ex) {
                System.Console.WriteLine($"Error updating entry: {ex.Message}");
            }
        }
    }
}

