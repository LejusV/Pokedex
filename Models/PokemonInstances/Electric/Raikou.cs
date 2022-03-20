using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Raikou PokemonInstance Class
	#region Raikou
	public class Raikou : PokemonInstance
	{
		#region Raikou Constructors
		/// <summary>
		/// Raikou Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Raikou(string nickname, int level)
		: base(
				RaikouSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raikou Constructor only waiting for a Level
		/// </summary>
		public Raikou(int level)
		: this( "Raikou", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raikou Constructor waiting for no params
		/// </summary>
		/*
		public Raikou() : this( "Raikou", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}