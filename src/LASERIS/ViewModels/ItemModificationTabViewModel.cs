using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using LASERIS.Models;
using System.Collections.Generic;


namespace LASERIS.ViewModels
{
    public class ItemModificationTabViewModel : BaseViewModel
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseApiUrl;
        public ICommand AddItemCommand { get; }


        private string _name;
        public string Name {
            get => _name;
            set {
                if (_name != value) {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        private string? _manufacturer;
        public string? Manufacturer {
            get => _manufacturer;
            set {
                if (_manufacturer != value) {
                    _manufacturer = value;
                    OnPropertyChanged(nameof(Manufacturer));
                }
            }
        }

        private string? _description;
        public string? Description {
            get => _description;
            set {
                if (_description != value) {
                    _description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }

        private string? _serialNumber;
        public string? SerialNumber {
            get => _serialNumber;
            set {
                if (_serialNumber != value) {
                    _serialNumber = value;
                    OnPropertyChanged(nameof(SerialNumber));
                }
            }
        }

        private string? _orderCode;
        public string? OrderCode {
            get => _orderCode;
            set {
                if (_orderCode != value) {
                    _orderCode = value;
                    OnPropertyChanged(nameof(OrderCode));
                }
            }
        }

        private string? _itemType;
        public string? ItemType {
            get => _itemType;
            set {
                if (_itemType != value) {
                    _itemType = value;
                    OnPropertyChanged(nameof(ItemType));
                }
            }
        }
        public List<string> ItemTypes { get; } = new() { "Component", "MCU", "Other" };

        private int _quantity;
        public int Quantity {
            get => _quantity;
            set {
                if (_quantity != value) {
                    _quantity = value;
                    OnPropertyChanged(nameof(Quantity));
                }
            }
        }

        private string? _signedOutTo;
        public string? SignedOutTo {
            get => _signedOutTo;
            set {
                if (_signedOutTo != value) {
                    _signedOutTo = value;
                    OnPropertyChanged(nameof(SignedOutTo));
                }
            }
        }


        private int? _signedOutToId;
        public int? SignedOutToId {
            get => _signedOutToId;
            set {
                if (_signedOutToId != value) {
                    _signedOutToId = value;
                    OnPropertyChanged(nameof(SignedOutToId));
                }
            }
        }

        private DateTime? _dateSignedOut;
        public DateTime? DateSignedOut {
            get => _dateSignedOut;
            set {
                if (_dateSignedOut != value) {
                    _dateSignedOut = value;
                    OnPropertyChanged(nameof(DateSignedOut));
                }
            }
        }

        public ItemModificationTabViewModel()
        {
            _httpClient = new HttpClient();
            _baseApiUrl = "http://localhost:5113/";

            AddItemCommand = new AsyncRelayCommand(OnAddItem);
        }

        private async Task OnAddItem()
        {
            Entry newEntry = new Entry
            {
                name = Name,
                manufacturerName = Manufacturer,
                description = Description,
                serialNumber = SerialNumber,
                orderCode = OrderCode,
                itemType = ItemType,
                quantity = Quantity,
                signedOutTo = SignedOutTo,
                signedOutToId = SignedOutToId,
                signedOutDate = DateSignedOut,
            };

            try
            {
                HttpResponseMessage response = await _httpClient.PostAsJsonAsync($"{_baseApiUrl}entry", newEntry);

                if (response.IsSuccessStatusCode)
                {
                    System.Console.WriteLine("Item successfully added");
                }
                else
                {
                    System.Console.WriteLine($"Failed to add item: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error adding item: {ex.Message}");
            }
        }
    }
}
