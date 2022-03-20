using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Spinarak PokemonInstance Class
	#region Spinarak
	public class Spinarak : PokemonInstance
	{
		#region Spinarak Constructors
		/// <summary>
		/// Spinarak Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Spinarak(string nickname, int level)
		: base(
				SpinarakSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spinarak Constructor only waiting for a Level
		/// </summary>
		public Spinarak(int level)
		: this( "Spinarak", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spinarak Constructor waiting for no params
		/// </summary>
		/*
		public Spinarak() : this( "Spinarak", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}