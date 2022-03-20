using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Joltik PokemonInstance Class
	#region Joltik
	public class Joltik : PokemonInstance
	{
		#region Joltik Constructors
		/// <summary>
		/// Joltik Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Joltik(string nickname, int level)
		: base(
				JoltikSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Joltik Constructor only waiting for a Level
		/// </summary>
		public Joltik(int level)
		: this( "Joltik", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Joltik Constructor waiting for no params
		/// </summary>
		/*
		public Joltik() : this( "Joltik", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}