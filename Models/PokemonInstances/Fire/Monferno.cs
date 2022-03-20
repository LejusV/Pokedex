using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Monferno PokemonInstance Class
	#region Monferno
	public class Monferno : PokemonInstance
	{
		#region Monferno Constructors
		/// <summary>
		/// Monferno Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Monferno(string nickname, int level)
		: base(
				MonfernoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Monferno Constructor only waiting for a Level
		/// </summary>
		public Monferno(int level)
		: this( "Monferno", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Monferno Constructor waiting for no params
		/// </summary>
		/*
		public Monferno() : this( "Monferno", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}