using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Burmy PokemonInstance Class
	#region Burmy
	public class Burmy : PokemonInstance
	{
		#region Burmy Constructors
		/// <summary>
		/// Burmy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Burmy(string nickname, int level)
		: base(
				BurmySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Burmy Constructor only waiting for a Level
		/// </summary>
		public Burmy(int level)
		: this( "Burmy", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Burmy Constructor waiting for no params
		/// </summary>
		/*
		public Burmy() : this( "Burmy", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}