using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Trumbeak PokemonInstance Class
	#region Trumbeak
	public class Trumbeak : PokemonInstance
	{
		#region Trumbeak Constructors
		/// <summary>
		/// Trumbeak Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Trumbeak(string nickname, int level)
		: base(
				TrumbeakSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trumbeak Constructor only waiting for a Level
		/// </summary>
		public Trumbeak(int level)
		: this( "Trumbeak", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trumbeak Constructor waiting for no params
		/// </summary>
		/*
		public Trumbeak() : this( "Trumbeak", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}