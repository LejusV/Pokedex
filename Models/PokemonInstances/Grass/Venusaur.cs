using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Venusaur PokemonInstance Class
	#region Venusaur
	public class Venusaur : PokemonInstance
	{
		#region Venusaur Constructors
		/// <summary>
		/// Venusaur Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Venusaur(string nickname, int level)
		: base(
				VenusaurSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venusaur Constructor only waiting for a Level
		/// </summary>
		public Venusaur(int level)
		: this( "Venusaur", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venusaur Constructor waiting for no params
		/// </summary>
		/*
		public Venusaur() : this( "Venusaur", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}