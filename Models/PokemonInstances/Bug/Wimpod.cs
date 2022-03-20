using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Wimpod PokemonInstance Class
	#region Wimpod
	public class Wimpod : PokemonInstance
	{
		#region Wimpod Constructors
		/// <summary>
		/// Wimpod Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Wimpod(string nickname, int level)
		: base(
				WimpodSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wimpod Constructor only waiting for a Level
		/// </summary>
		public Wimpod(int level)
		: this( "Wimpod", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wimpod Constructor waiting for no params
		/// </summary>
		/*
		public Wimpod() : this( "Wimpod", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}