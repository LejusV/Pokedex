using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bonsly PokemonInstance Class
	#region Bonsly
	public class Bonsly : PokemonInstance
	{
		#region Bonsly Constructors
		/// <summary>
		/// Bonsly Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bonsly(string nickname, int level)
		: base(
				BonslySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bonsly Constructor only waiting for a Level
		/// </summary>
		public Bonsly(int level)
		: this( "Bonsly", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bonsly Constructor waiting for no params
		/// </summary>
		/*
		public Bonsly() : this( "Bonsly", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}