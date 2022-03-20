using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Weedle PokemonInstance Class
	#region Weedle
	public class Weedle : PokemonInstance
	{
		#region Weedle Constructors
		/// <summary>
		/// Weedle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Weedle(string nickname, int level)
		: base(
				WeedleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weedle Constructor only waiting for a Level
		/// </summary>
		public Weedle(int level)
		: this( "Weedle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weedle Constructor waiting for no params
		/// </summary>
		/*
		public Weedle() : this( "Weedle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}