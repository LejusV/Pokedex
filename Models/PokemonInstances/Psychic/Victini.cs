using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Victini PokemonInstance Class
	#region Victini
	public class Victini : PokemonInstance
	{
		#region Victini Constructors
		/// <summary>
		/// Victini Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Victini(string nickname, int level)
		: base(
				VictiniSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Victini Constructor only waiting for a Level
		/// </summary>
		public Victini(int level)
		: this( "Victini", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Victini Constructor waiting for no params
		/// </summary>
		/*
		public Victini() : this( "Victini", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}