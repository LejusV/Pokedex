using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Urshifu-Single-Strike PokemonInstance Class
	#region Urshifu-Single-Strike
	public class UrshifuSingleStrike : PokemonInstance
	{
		#region Urshifu-Single-Strike Constructors
		/// <summary>
		/// Urshifu-Single-Strike Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public UrshifuSingleStrike(string nickname, int level)
		: base(
				UrshifuSingleStrikeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Urshifu-Single-Strike Constructor only waiting for a Level
		/// </summary>
		public UrshifuSingleStrike(int level)
		: this( "Urshifu-Single-Strike", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Urshifu-Single-Strike Constructor waiting for no params
		/// </summary>
		/*
		public UrshifuSingleStrike() : this( "Urshifu-Single-Strike", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}