using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Binacle PokemonInstance Class
	#region Binacle
	public class Binacle : PokemonInstance
	{
		#region Binacle Constructors
		/// <summary>
		/// Binacle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Binacle(string nickname, int level)
		: base(
				BinacleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Binacle Constructor only waiting for a Level
		/// </summary>
		public Binacle(int level)
		: this( "Binacle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Binacle Constructor waiting for no params
		/// </summary>
		/*
		public Binacle() : this( "Binacle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}