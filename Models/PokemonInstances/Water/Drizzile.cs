using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Drizzile PokemonInstance Class
	#region Drizzile
	public class Drizzile : PokemonInstance
	{
		#region Drizzile Constructors
		/// <summary>
		/// Drizzile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Drizzile(string nickname, int level)
		: base(
				DrizzileSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drizzile Constructor only waiting for a Level
		/// </summary>
		public Drizzile(int level)
		: this( "Drizzile", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drizzile Constructor waiting for no params
		/// </summary>
		/*
		public Drizzile() : this( "Drizzile", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}