using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    public partial class CharacterViewModel : ObservableObject
    {
        public CharacterViewModel()
        {
            AddCommand = new Command(Add);
        }

        [ObservableProperty]
        public string _nome;

        [ObservableProperty]
        public int _nivel;

        [ObservableProperty]
        public string _classe;

        [ObservableProperty]
        public string _raca;

        private ObservableCollection<Character> _characters = new ObservableCollection<Character>();
        public ObservableCollection<Character> Characters
        {
            get { return _characters; }
            set { _characters = value; }
        }

        public ICommand AddCommand { get; }

        public void Add()
        {
            Character person = new Character(Nome, Classe, Raca, Nivel);
            _characters.Add(person);    
        }

    }
}
