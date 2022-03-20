using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Weezing PokemonInstance Class
	#region Weezing
	public class Weezing : PokemonInstance
	{
		#region Weezing Constructors
		/// <summary>
		/// Weezing Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Weezing(string nickname, int level)
		: base(
				WeezingSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weezing Constructor only waiting for a Level
		/// </summary>
		public Weezing(int level)
		: this( "Weezing", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weezing Constructor waiting for no params
		/// </summary>
		/*
		public Weezing() : this( "Weezing", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}