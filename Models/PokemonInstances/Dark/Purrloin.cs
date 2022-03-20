using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Purrloin PokemonInstance Class
	#region Purrloin
	public class Purrloin : PokemonInstance
	{
		#region Purrloin Constructors
		/// <summary>
		/// Purrloin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Purrloin(string nickname, int level)
		: base(
				PurrloinSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Purrloin Constructor only waiting for a Level
		/// </summary>
		public Purrloin(int level)
		: this( "Purrloin", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Purrloin Constructor waiting for no params
		/// </summary>
		/*
		public Purrloin() : this( "Purrloin", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}