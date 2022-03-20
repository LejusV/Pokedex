using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Shieldon PokemonInstance Class
	#region Shieldon
	public class Shieldon : PokemonInstance
	{
		#region Shieldon Constructors
		/// <summary>
		/// Shieldon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Shieldon(string nickname, int level)
		: base(
				ShieldonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shieldon Constructor only waiting for a Level
		/// </summary>
		public Shieldon(int level)
		: this( "Shieldon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shieldon Constructor waiting for no params
		/// </summary>
		/*
		public Shieldon() : this( "Shieldon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}