using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tapu-Bulu PokemonInstance Class
	#region Tapu-Bulu
	public class TapuBulu : PokemonInstance
	{
		#region Tapu-Bulu Constructors
		/// <summary>
		/// Tapu-Bulu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TapuBulu(string nickname, int level)
		: base(
				TapuBuluSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Bulu Constructor only waiting for a Level
		/// </summary>
		public TapuBulu(int level)
		: this( "Tapu-Bulu", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Bulu Constructor waiting for no params
		/// </summary>
		/*
		public TapuBulu() : this( "Tapu-Bulu", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}