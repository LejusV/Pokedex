using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Simipour PokemonInstance Class
	#region Simipour
	public class Simipour : PokemonInstance
	{
		#region Simipour Constructors
		/// <summary>
		/// Simipour Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Simipour(string nickname, int level)
		: base(
				SimipourSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simipour Constructor only waiting for a Level
		/// </summary>
		public Simipour(int level)
		: this( "Simipour", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simipour Constructor waiting for no params
		/// </summary>
		/*
		public Simipour() : this( "Simipour", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}