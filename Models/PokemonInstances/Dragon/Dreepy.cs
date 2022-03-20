using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dreepy PokemonInstance Class
	#region Dreepy
	public class Dreepy : PokemonInstance
	{
		#region Dreepy Constructors
		/// <summary>
		/// Dreepy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dreepy(string nickname, int level)
		: base(
				DreepySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dreepy Constructor only waiting for a Level
		/// </summary>
		public Dreepy(int level)
		: this( "Dreepy", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dreepy Constructor waiting for no params
		/// </summary>
		/*
		public Dreepy() : this( "Dreepy", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}