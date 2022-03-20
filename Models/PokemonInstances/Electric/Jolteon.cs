using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Jolteon PokemonInstance Class
	#region Jolteon
	public class Jolteon : PokemonInstance
	{
		#region Jolteon Constructors
		/// <summary>
		/// Jolteon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Jolteon(string nickname, int level)
		: base(
				JolteonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jolteon Constructor only waiting for a Level
		/// </summary>
		public Jolteon(int level)
		: this( "Jolteon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jolteon Constructor waiting for no params
		/// </summary>
		/*
		public Jolteon() : this( "Jolteon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}