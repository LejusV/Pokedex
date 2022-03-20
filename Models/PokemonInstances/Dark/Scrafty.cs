using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Scrafty PokemonInstance Class
	#region Scrafty
	public class Scrafty : PokemonInstance
	{
		#region Scrafty Constructors
		/// <summary>
		/// Scrafty Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Scrafty(string nickname, int level)
		: base(
				ScraftySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scrafty Constructor only waiting for a Level
		/// </summary>
		public Scrafty(int level)
		: this( "Scrafty", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scrafty Constructor waiting for no params
		/// </summary>
		/*
		public Scrafty() : this( "Scrafty", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}