using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Grovyle PokemonInstance Class
	#region Grovyle
	public class Grovyle : PokemonInstance
	{
		#region Grovyle Constructors
		/// <summary>
		/// Grovyle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Grovyle(string nickname, int level)
		: base(
				GrovyleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grovyle Constructor only waiting for a Level
		/// </summary>
		public Grovyle(int level)
		: this( "Grovyle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grovyle Constructor waiting for no params
		/// </summary>
		/*
		public Grovyle() : this( "Grovyle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}