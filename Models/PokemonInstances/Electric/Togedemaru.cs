using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Togedemaru PokemonInstance Class
	#region Togedemaru
	public class Togedemaru : PokemonInstance
	{
		#region Togedemaru Constructors
		/// <summary>
		/// Togedemaru Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Togedemaru(string nickname, int level)
		: base(
				TogedemaruSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togedemaru Constructor only waiting for a Level
		/// </summary>
		public Togedemaru(int level)
		: this( "Togedemaru", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togedemaru Constructor waiting for no params
		/// </summary>
		/*
		public Togedemaru() : this( "Togedemaru", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}