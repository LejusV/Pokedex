using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sandslash PokemonInstance Class
	#region Sandslash
	public class Sandslash : PokemonInstance
	{
		#region Sandslash Constructors
		/// <summary>
		/// Sandslash Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sandslash(string nickname, int level)
		: base(
				SandslashSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandslash Constructor only waiting for a Level
		/// </summary>
		public Sandslash(int level)
		: this( "Sandslash", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandslash Constructor waiting for no params
		/// </summary>
		/*
		public Sandslash() : this( "Sandslash", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}