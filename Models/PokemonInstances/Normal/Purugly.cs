using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Purugly PokemonInstance Class
	#region Purugly
	public class Purugly : PokemonInstance
	{
		#region Purugly Constructors
		/// <summary>
		/// Purugly Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Purugly(string nickname, int level)
		: base(
				PuruglySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Purugly Constructor only waiting for a Level
		/// </summary>
		public Purugly(int level)
		: this( "Purugly", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Purugly Constructor waiting for no params
		/// </summary>
		/*
		public Purugly() : this( "Purugly", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}