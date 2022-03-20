using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cubchoo PokemonInstance Class
	#region Cubchoo
	public class Cubchoo : PokemonInstance
	{
		#region Cubchoo Constructors
		/// <summary>
		/// Cubchoo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cubchoo(string nickname, int level)
		: base(
				CubchooSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cubchoo Constructor only waiting for a Level
		/// </summary>
		public Cubchoo(int level)
		: this( "Cubchoo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cubchoo Constructor waiting for no params
		/// </summary>
		/*
		public Cubchoo() : this( "Cubchoo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}