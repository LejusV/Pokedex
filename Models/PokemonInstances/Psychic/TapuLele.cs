using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tapu-Lele PokemonInstance Class
	#region Tapu-Lele
	public class TapuLele : PokemonInstance
	{
		#region Tapu-Lele Constructors
		/// <summary>
		/// Tapu-Lele Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TapuLele(string nickname, int level)
		: base(
				TapuLeleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Lele Constructor only waiting for a Level
		/// </summary>
		public TapuLele(int level)
		: this( "Tapu-Lele", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Lele Constructor waiting for no params
		/// </summary>
		/*
		public TapuLele() : this( "Tapu-Lele", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}