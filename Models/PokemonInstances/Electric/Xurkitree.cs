using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Xurkitree PokemonInstance Class
	#region Xurkitree
	public class Xurkitree : PokemonInstance
	{
		#region Xurkitree Constructors
		/// <summary>
		/// Xurkitree Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Xurkitree(string nickname, int level)
		: base(
				XurkitreeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xurkitree Constructor only waiting for a Level
		/// </summary>
		public Xurkitree(int level)
		: this( "Xurkitree", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xurkitree Constructor waiting for no params
		/// </summary>
		/*
		public Xurkitree() : this( "Xurkitree", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}