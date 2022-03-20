using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Trevenant PokemonInstance Class
	#region Trevenant
	public class Trevenant : PokemonInstance
	{
		#region Trevenant Constructors
		/// <summary>
		/// Trevenant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Trevenant(string nickname, int level)
		: base(
				TrevenantSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trevenant Constructor only waiting for a Level
		/// </summary>
		public Trevenant(int level)
		: this( "Trevenant", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trevenant Constructor waiting for no params
		/// </summary>
		/*
		public Trevenant() : this( "Trevenant", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}