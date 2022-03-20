using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Nihilego PokemonInstance Class
	#region Nihilego
	public class Nihilego : PokemonInstance
	{
		#region Nihilego Constructors
		/// <summary>
		/// Nihilego Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Nihilego(string nickname, int level)
		: base(
				NihilegoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nihilego Constructor only waiting for a Level
		/// </summary>
		public Nihilego(int level)
		: this( "Nihilego", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nihilego Constructor waiting for no params
		/// </summary>
		/*
		public Nihilego() : this( "Nihilego", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}