using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Frogadier PokemonInstance Class
	#region Frogadier
	public class Frogadier : PokemonInstance
	{
		#region Frogadier Constructors
		/// <summary>
		/// Frogadier Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Frogadier(string nickname, int level)
		: base(
				FrogadierSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frogadier Constructor only waiting for a Level
		/// </summary>
		public Frogadier(int level)
		: this( "Frogadier", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frogadier Constructor waiting for no params
		/// </summary>
		/*
		public Frogadier() : this( "Frogadier", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}