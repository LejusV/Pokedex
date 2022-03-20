using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Blitzle PokemonInstance Class
	#region Blitzle
	public class Blitzle : PokemonInstance
	{
		#region Blitzle Constructors
		/// <summary>
		/// Blitzle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Blitzle(string nickname, int level)
		: base(
				BlitzleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blitzle Constructor only waiting for a Level
		/// </summary>
		public Blitzle(int level)
		: this( "Blitzle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blitzle Constructor waiting for no params
		/// </summary>
		/*
		public Blitzle() : this( "Blitzle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}