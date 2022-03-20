using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Teddiursa PokemonInstance Class
	#region Teddiursa
	public class Teddiursa : PokemonInstance
	{
		#region Teddiursa Constructors
		/// <summary>
		/// Teddiursa Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Teddiursa(string nickname, int level)
		: base(
				TeddiursaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Teddiursa Constructor only waiting for a Level
		/// </summary>
		public Teddiursa(int level)
		: this( "Teddiursa", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Teddiursa Constructor waiting for no params
		/// </summary>
		/*
		public Teddiursa() : this( "Teddiursa", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}