using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Munna PokemonInstance Class
	#region Munna
	public class Munna : PokemonInstance
	{
		#region Munna Constructors
		/// <summary>
		/// Munna Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Munna(string nickname, int level)
		: base(
				MunnaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Munna Constructor only waiting for a Level
		/// </summary>
		public Munna(int level)
		: this( "Munna", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Munna Constructor waiting for no params
		/// </summary>
		/*
		public Munna() : this( "Munna", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}