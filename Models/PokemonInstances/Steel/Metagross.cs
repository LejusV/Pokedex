using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Metagross PokemonInstance Class
	#region Metagross
	public class Metagross : PokemonInstance
	{
		#region Metagross Constructors
		/// <summary>
		/// Metagross Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Metagross(string nickname, int level)
		: base(
				MetagrossSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metagross Constructor only waiting for a Level
		/// </summary>
		public Metagross(int level)
		: this( "Metagross", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metagross Constructor waiting for no params
		/// </summary>
		/*
		public Metagross() : this( "Metagross", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}