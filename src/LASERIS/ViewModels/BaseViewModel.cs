using System.Net.Http;
using System.ComponentModel;

namespace LASERIS.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        protected HttpClient _httpClient;
        protected string _baseApiUrl;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public BaseViewModel() {
            HttpClientHandler handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
            };
            _httpClient = new HttpClient(handler);
            
            _baseApiUrl = Environment.GetEnvironmentVariable("LASERISAPI_URL") 
        }
    }
}