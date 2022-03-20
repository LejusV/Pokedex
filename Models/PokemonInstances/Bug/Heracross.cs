using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Heracross PokemonInstance Class
	#region Heracross
	public class Heracross : PokemonInstance
	{
		#region Heracross Constructors
		/// <summary>
		/// Heracross Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Heracross(string nickname, int level)
		: base(
				HeracrossSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heracross Constructor only waiting for a Level
		/// </summary>
		public Heracross(int level)
		: this( "Heracross", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heracross Constructor waiting for no params
		/// </summary>
		/*
		public Heracross() : this( "Heracross", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}