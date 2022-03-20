using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Floette PokemonInstance Class
	#region Floette
	public class Floette : PokemonInstance
	{
		#region Floette Constructors
		/// <summary>
		/// Floette Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Floette(string nickname, int level)
		: base(
				FloetteSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Floette Constructor only waiting for a Level
		/// </summary>
		public Floette(int level)
		: this( "Floette", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Floette Constructor waiting for no params
		/// </summary>
		/*
		public Floette() : this( "Floette", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}