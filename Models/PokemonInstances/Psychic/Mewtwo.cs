using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mewtwo PokemonInstance Class
	#region Mewtwo
	public class Mewtwo : PokemonInstance
	{
		#region Mewtwo Constructors
		/// <summary>
		/// Mewtwo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mewtwo(string nickname, int level)
		: base(
				MewtwoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mewtwo Constructor only waiting for a Level
		/// </summary>
		public Mewtwo(int level)
		: this( "Mewtwo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mewtwo Constructor waiting for no params
		/// </summary>
		/*
		public Mewtwo() : this( "Mewtwo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}