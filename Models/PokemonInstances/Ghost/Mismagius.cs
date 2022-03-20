using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mismagius PokemonInstance Class
	#region Mismagius
	public class Mismagius : PokemonInstance
	{
		#region Mismagius Constructors
		/// <summary>
		/// Mismagius Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mismagius(string nickname, int level)
		: base(
				MismagiusSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mismagius Constructor only waiting for a Level
		/// </summary>
		public Mismagius(int level)
		: this( "Mismagius", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mismagius Constructor waiting for no params
		/// </summary>
		/*
		public Mismagius() : this( "Mismagius", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}