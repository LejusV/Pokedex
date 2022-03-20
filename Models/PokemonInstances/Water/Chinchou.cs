using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Chinchou PokemonInstance Class
	#region Chinchou
	public class Chinchou : PokemonInstance
	{
		#region Chinchou Constructors
		/// <summary>
		/// Chinchou Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Chinchou(string nickname, int level)
		: base(
				ChinchouSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chinchou Constructor only waiting for a Level
		/// </summary>
		public Chinchou(int level)
		: this( "Chinchou", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chinchou Constructor waiting for no params
		/// </summary>
		/*
		public Chinchou() : this( "Chinchou", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}