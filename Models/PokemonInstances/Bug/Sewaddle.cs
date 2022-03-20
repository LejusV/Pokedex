using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sewaddle PokemonInstance Class
	#region Sewaddle
	public class Sewaddle : PokemonInstance
	{
		#region Sewaddle Constructors
		/// <summary>
		/// Sewaddle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sewaddle(string nickname, int level)
		: base(
				SewaddleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sewaddle Constructor only waiting for a Level
		/// </summary>
		public Sewaddle(int level)
		: this( "Sewaddle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sewaddle Constructor waiting for no params
		/// </summary>
		/*
		public Sewaddle() : this( "Sewaddle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}