using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Snorlax PokemonInstance Class
	#region Snorlax
	public class Snorlax : PokemonInstance
	{
		#region Snorlax Constructors
		/// <summary>
		/// Snorlax Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Snorlax(string nickname, int level)
		: base(
				SnorlaxSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snorlax Constructor only waiting for a Level
		/// </summary>
		public Snorlax(int level)
		: this( "Snorlax", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snorlax Constructor waiting for no params
		/// </summary>
		/*
		public Snorlax() : this( "Snorlax", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}