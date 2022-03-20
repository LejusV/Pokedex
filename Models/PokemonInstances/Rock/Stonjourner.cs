using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Stonjourner PokemonInstance Class
	#region Stonjourner
	public class Stonjourner : PokemonInstance
	{
		#region Stonjourner Constructors
		/// <summary>
		/// Stonjourner Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Stonjourner(string nickname, int level)
		: base(
				StonjournerSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stonjourner Constructor only waiting for a Level
		/// </summary>
		public Stonjourner(int level)
		: this( "Stonjourner", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stonjourner Constructor waiting for no params
		/// </summary>
		/*
		public Stonjourner() : this( "Stonjourner", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}