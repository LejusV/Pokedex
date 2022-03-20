using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tapu-Koko PokemonInstance Class
	#region Tapu-Koko
	public class TapuKoko : PokemonInstance
	{
		#region Tapu-Koko Constructors
		/// <summary>
		/// Tapu-Koko Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TapuKoko(string nickname, int level)
		: base(
				TapuKokoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Koko Constructor only waiting for a Level
		/// </summary>
		public TapuKoko(int level)
		: this( "Tapu-Koko", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Koko Constructor waiting for no params
		/// </summary>
		/*
		public TapuKoko() : this( "Tapu-Koko", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}