using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Watchog PokemonInstance Class
	#region Watchog
	public class Watchog : PokemonInstance
	{
		#region Watchog Constructors
		/// <summary>
		/// Watchog Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Watchog(string nickname, int level)
		: base(
				WatchogSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Watchog Constructor only waiting for a Level
		/// </summary>
		public Watchog(int level)
		: this( "Watchog", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Watchog Constructor waiting for no params
		/// </summary>
		/*
		public Watchog() : this( "Watchog", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}