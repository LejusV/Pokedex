using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Crabrawler PokemonInstance Class
	#region Crabrawler
	public class Crabrawler : PokemonInstance
	{
		#region Crabrawler Constructors
		/// <summary>
		/// Crabrawler Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Crabrawler(string nickname, int level)
		: base(
				CrabrawlerSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crabrawler Constructor only waiting for a Level
		/// </summary>
		public Crabrawler(int level)
		: this( "Crabrawler", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crabrawler Constructor waiting for no params
		/// </summary>
		/*
		public Crabrawler() : this( "Crabrawler", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}