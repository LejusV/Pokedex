using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hariyama PokemonInstance Class
	#region Hariyama
	public class Hariyama : PokemonInstance
	{
		#region Hariyama Constructors
		/// <summary>
		/// Hariyama Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Hariyama(string nickname, int level)
		: base(
				HariyamaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hariyama Constructor only waiting for a Level
		/// </summary>
		public Hariyama(int level)
		: this( "Hariyama", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hariyama Constructor waiting for no params
		/// </summary>
		/*
		public Hariyama() : this( "Hariyama", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}