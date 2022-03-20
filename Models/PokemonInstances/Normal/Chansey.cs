using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Chansey PokemonInstance Class
	#region Chansey
	public class Chansey : PokemonInstance
	{
		#region Chansey Constructors
		/// <summary>
		/// Chansey Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Chansey(string nickname, int level)
		: base(
				ChanseySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chansey Constructor only waiting for a Level
		/// </summary>
		public Chansey(int level)
		: this( "Chansey", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chansey Constructor waiting for no params
		/// </summary>
		/*
		public Chansey() : this( "Chansey", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}