using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Banette PokemonInstance Class
	#region Banette
	public class Banette : PokemonInstance
	{
		#region Banette Constructors
		/// <summary>
		/// Banette Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Banette(string nickname, int level)
		: base(
				BanetteSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Banette Constructor only waiting for a Level
		/// </summary>
		public Banette(int level)
		: this( "Banette", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Banette Constructor waiting for no params
		/// </summary>
		/*
		public Banette() : this( "Banette", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}