using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Noivern PokemonInstance Class
	#region Noivern
	public class Noivern : PokemonInstance
	{
		#region Noivern Constructors
		/// <summary>
		/// Noivern Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Noivern(string nickname, int level)
		: base(
				NoivernSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noivern Constructor only waiting for a Level
		/// </summary>
		public Noivern(int level)
		: this( "Noivern", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noivern Constructor waiting for no params
		/// </summary>
		/*
		public Noivern() : this( "Noivern", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}