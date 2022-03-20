using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Minccino PokemonInstance Class
	#region Minccino
	public class Minccino : PokemonInstance
	{
		#region Minccino Constructors
		/// <summary>
		/// Minccino Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Minccino(string nickname, int level)
		: base(
				MinccinoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minccino Constructor only waiting for a Level
		/// </summary>
		public Minccino(int level)
		: this( "Minccino", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minccino Constructor waiting for no params
		/// </summary>
		/*
		public Minccino() : this( "Minccino", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}