using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Girafarig PokemonInstance Class
	#region Girafarig
	public class Girafarig : PokemonInstance
	{
		#region Girafarig Constructors
		/// <summary>
		/// Girafarig Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Girafarig(string nickname, int level)
		: base(
				GirafarigSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Girafarig Constructor only waiting for a Level
		/// </summary>
		public Girafarig(int level)
		: this( "Girafarig", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Girafarig Constructor waiting for no params
		/// </summary>
		/*
		public Girafarig() : this( "Girafarig", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}