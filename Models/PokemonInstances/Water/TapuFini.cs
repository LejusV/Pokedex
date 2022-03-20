using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tapu-Fini PokemonInstance Class
	#region Tapu-Fini
	public class TapuFini : PokemonInstance
	{
		#region Tapu-Fini Constructors
		/// <summary>
		/// Tapu-Fini Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TapuFini(string nickname, int level)
		: base(
				TapuFiniSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Fini Constructor only waiting for a Level
		/// </summary>
		public TapuFini(int level)
		: this( "Tapu-Fini", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Fini Constructor waiting for no params
		/// </summary>
		/*
		public TapuFini() : this( "Tapu-Fini", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}