using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Morgrem PokemonInstance Class
	#region Morgrem
	public class Morgrem : PokemonInstance
	{
		#region Morgrem Constructors
		/// <summary>
		/// Morgrem Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Morgrem(string nickname, int level)
		: base(
				MorgremSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morgrem Constructor only waiting for a Level
		/// </summary>
		public Morgrem(int level)
		: this( "Morgrem", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morgrem Constructor waiting for no params
		/// </summary>
		/*
		public Morgrem() : this( "Morgrem", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}