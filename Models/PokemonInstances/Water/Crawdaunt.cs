using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Crawdaunt PokemonInstance Class
	#region Crawdaunt
	public class Crawdaunt : PokemonInstance
	{
		#region Crawdaunt Constructors
		/// <summary>
		/// Crawdaunt Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Crawdaunt(string nickname, int level)
		: base(
				CrawdauntSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crawdaunt Constructor only waiting for a Level
		/// </summary>
		public Crawdaunt(int level)
		: this( "Crawdaunt", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crawdaunt Constructor waiting for no params
		/// </summary>
		/*
		public Crawdaunt() : this( "Crawdaunt", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}