using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AverysXamarinProject.ViewModels
{
    public class MyViewModel : BaseViewModel
    {
        public Command DoneCommand { get; private set; }

        public MyViewModel()
        {
            DoneCommand = new Command(async () => await Done());
            TextToTitleCase = "This is the main page!";
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private string _age;
        public string Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        private bool _show;
        public bool Show
        {
            get => _show;
            set
            {
                _show = value;
                OnPropertyChanged(nameof(Show));
            }
        }

        private string _textToTitleCase;
        public string TextToTitleCase
        {
            get
            {
                return _textToTitleCase;
            }
            set
            {
                _textToTitleCase = value;
                OnPropertyChanged(nameof(TextToTitleCase));
            }
        }

        private async Task Done()
        {
            await Navigation.PopModalAsync();
        }
    }
}
