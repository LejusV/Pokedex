using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Naganadel PokemonInstance Class
	#region Naganadel
	public class Naganadel : PokemonInstance
	{
		#region Naganadel Constructors
		/// <summary>
		/// Naganadel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Naganadel(string nickname, int level)
		: base(
				NaganadelSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Naganadel Constructor only waiting for a Level
		/// </summary>
		public Naganadel(int level)
		: this( "Naganadel", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Naganadel Constructor waiting for no params
		/// </summary>
		/*
		public Naganadel() : this( "Naganadel", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}