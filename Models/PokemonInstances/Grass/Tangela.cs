using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tangela PokemonInstance Class
	#region Tangela
	public class Tangela : PokemonInstance
	{
		#region Tangela Constructors
		/// <summary>
		/// Tangela Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tangela(string nickname, int level)
		: base(
				TangelaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tangela Constructor only waiting for a Level
		/// </summary>
		public Tangela(int level)
		: this( "Tangela", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tangela Constructor waiting for no params
		/// </summary>
		/*
		public Tangela() : this( "Tangela", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}