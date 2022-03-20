using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bagon PokemonInstance Class
	#region Bagon
	public class Bagon : PokemonInstance
	{
		#region Bagon Constructors
		/// <summary>
		/// Bagon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bagon(string nickname, int level)
		: base(
				BagonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bagon Constructor only waiting for a Level
		/// </summary>
		public Bagon(int level)
		: this( "Bagon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bagon Constructor waiting for no params
		/// </summary>
		/*
		public Bagon() : this( "Bagon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}