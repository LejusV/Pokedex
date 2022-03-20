using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Rufflet PokemonInstance Class
	#region Rufflet
	public class Rufflet : PokemonInstance
	{
		#region Rufflet Constructors
		/// <summary>
		/// Rufflet Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Rufflet(string nickname, int level)
		: base(
				RuffletSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rufflet Constructor only waiting for a Level
		/// </summary>
		public Rufflet(int level)
		: this( "Rufflet", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rufflet Constructor waiting for no params
		/// </summary>
		/*
		public Rufflet() : this( "Rufflet", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}