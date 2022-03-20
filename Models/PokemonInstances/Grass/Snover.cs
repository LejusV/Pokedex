using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Snover PokemonInstance Class
	#region Snover
	public class Snover : PokemonInstance
	{
		#region Snover Constructors
		/// <summary>
		/// Snover Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Snover(string nickname, int level)
		: base(
				SnoverSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snover Constructor only waiting for a Level
		/// </summary>
		public Snover(int level)
		: this( "Snover", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snover Constructor waiting for no params
		/// </summary>
		/*
		public Snover() : this( "Snover", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}