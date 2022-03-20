using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Timburr PokemonInstance Class
	#region Timburr
	public class Timburr : PokemonInstance
	{
		#region Timburr Constructors
		/// <summary>
		/// Timburr Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Timburr(string nickname, int level)
		: base(
				TimburrSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Timburr Constructor only waiting for a Level
		/// </summary>
		public Timburr(int level)
		: this( "Timburr", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Timburr Constructor waiting for no params
		/// </summary>
		/*
		public Timburr() : this( "Timburr", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}