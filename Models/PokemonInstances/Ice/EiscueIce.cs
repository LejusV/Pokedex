using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Eiscue-Ice PokemonInstance Class
	#region Eiscue-Ice
	public class EiscueIce : PokemonInstance
	{
		#region Eiscue-Ice Constructors
		/// <summary>
		/// Eiscue-Ice Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public EiscueIce(string nickname, int level)
		: base(
				EiscueIceSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eiscue-Ice Constructor only waiting for a Level
		/// </summary>
		public EiscueIce(int level)
		: this( "Eiscue-Ice", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eiscue-Ice Constructor waiting for no params
		/// </summary>
		/*
		public EiscueIce() : this( "Eiscue-Ice", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}