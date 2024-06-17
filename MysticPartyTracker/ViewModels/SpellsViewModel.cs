using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using MysticPartyTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels;

public partial class SpellsViewModel : ObservableObject
{
	private readonly ISpellService _spellservice;
    [ObservableProperty]
	private ObservableCollection<Response> _result = new ObservableCollection<Response>();

    public SpellsViewModel(ISpellService spellservice)
	{
		_spellservice = spellservice;
		LoadSpellsCommand = new AsyncRelayCommand(LoadSpellsAsync);

	}
	
	public IAsyncRelayCommand LoadSpellsCommand { get; }

	private async Task LoadSpellsAsync()
	{
		var spells = await _spellservice.GetSpellAsync();
	
	}
	
}