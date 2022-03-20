using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Milcery PokemonInstance Class
	#region Milcery
	public class Milcery : PokemonInstance
	{
		#region Milcery Constructors
		/// <summary>
		/// Milcery Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Milcery(string nickname, int level)
		: base(
				MilcerySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Milcery Constructor only waiting for a Level
		/// </summary>
		public Milcery(int level)
		: this( "Milcery", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Milcery Constructor waiting for no params
		/// </summary>
		/*
		public Milcery() : this( "Milcery", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}