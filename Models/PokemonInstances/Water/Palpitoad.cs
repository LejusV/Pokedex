using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Palpitoad PokemonInstance Class
	#region Palpitoad
	public class Palpitoad : PokemonInstance
	{
		#region Palpitoad Constructors
		/// <summary>
		/// Palpitoad Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Palpitoad(string nickname, int level)
		: base(
				PalpitoadSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palpitoad Constructor only waiting for a Level
		/// </summary>
		public Palpitoad(int level)
		: this( "Palpitoad", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palpitoad Constructor waiting for no params
		/// </summary>
		/*
		public Palpitoad() : this( "Palpitoad", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}