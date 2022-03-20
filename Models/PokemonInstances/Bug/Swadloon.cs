using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Swadloon PokemonInstance Class
	#region Swadloon
	public class Swadloon : PokemonInstance
	{
		#region Swadloon Constructors
		/// <summary>
		/// Swadloon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Swadloon(string nickname, int level)
		: base(
				SwadloonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swadloon Constructor only waiting for a Level
		/// </summary>
		public Swadloon(int level)
		: this( "Swadloon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swadloon Constructor waiting for no params
		/// </summary>
		/*
		public Swadloon() : this( "Swadloon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}