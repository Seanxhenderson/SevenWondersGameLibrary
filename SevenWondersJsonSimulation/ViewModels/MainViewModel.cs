using Newtonsoft.Json;
using SevenWondersGameLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Storage;
using Windows.Storage.Streams;

namespace SevenWondersJsonSimulation.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ICommand simulateCommand = null;
        private string jsonText;
        private RelayCommand readCommand;

        public MainViewModel()
        {

        }

        public async Task WriteToJsonFile()
        {
            var ageICards = CardFactory.PopulateAgeIIICards();

            StorageFolder folder = Windows.Storage.ApplicationData.Current.LocalFolder;
            StorageFile file = await folder.CreateFileAsync("AgeICards.json", CreationCollisionOption.ReplaceExisting);

            string jsonContents = JsonConvert.SerializeObject(ageICards);

            using (IRandomAccessStream textStream = await file.OpenAsync(FileAccessMode.ReadWrite))
            {
                // write the JSON string!
                using (DataWriter textWriter = new DataWriter(textStream))
                {
                    textWriter.WriteString(jsonContents);
                    await textWriter.StoreAsync();
                }
            }
        }

        public async Task ReadFromJsonFile()
        {
            JsonSerializer serializer = new JsonSerializer();
            StorageFolder folder = Windows.Storage.ApplicationData.Current.LocalFolder;
            StorageFile file = await folder.GetFileAsync("AgeICards.json");

            this.JsonText = await Windows.Storage.FileIO.ReadTextAsync(file);
        }

        public string JsonText
        {
            get { return this.jsonText; }
            set
            {
                this.jsonText = value;
                OnPropertyChanged(nameof(JsonText));
            }
        }

        public ICommand ReadCommand
        {
            get
            {
                return this.readCommand ?? new RelayCommand(
                    async () =>
                    {
                        await ReadFromJsonFile();
                    }
                    );
            }
        }

        public ICommand SimulateCommand
        {
            get
            {
                return this.simulateCommand ?? new RelayCommand(
                    async () =>
                    {
                        await WriteToJsonFile();
                    }
                    );
            }
        }
    }
}
