using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Squirtle PokemonInstance Class
	#region Squirtle
	public class Squirtle : PokemonInstance
	{
		#region Squirtle Constructors
		/// <summary>
		/// Squirtle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Squirtle(string nickname, int level)
		: base(
				SquirtleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Squirtle Constructor only waiting for a Level
		/// </summary>
		public Squirtle(int level)
		: this( "Squirtle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Squirtle Constructor waiting for no params
		/// </summary>
		/*
		public Squirtle() : this( "Squirtle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}