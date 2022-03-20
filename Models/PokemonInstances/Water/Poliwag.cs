using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Poliwag PokemonInstance Class
	#region Poliwag
	public class Poliwag : PokemonInstance
	{
		#region Poliwag Constructors
		/// <summary>
		/// Poliwag Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Poliwag(string nickname, int level)
		: base(
				PoliwagSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwag Constructor only waiting for a Level
		/// </summary>
		public Poliwag(int level)
		: this( "Poliwag", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwag Constructor waiting for no params
		/// </summary>
		/*
		public Poliwag() : this( "Poliwag", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}