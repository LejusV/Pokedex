using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mudkip PokemonInstance Class
	#region Mudkip
	public class Mudkip : PokemonInstance
	{
		#region Mudkip Constructors
		/// <summary>
		/// Mudkip Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mudkip(string nickname, int level)
		: base(
				MudkipSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudkip Constructor only waiting for a Level
		/// </summary>
		public Mudkip(int level)
		: this( "Mudkip", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudkip Constructor waiting for no params
		/// </summary>
		/*
		public Mudkip() : this( "Mudkip", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}