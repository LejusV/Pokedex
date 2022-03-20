using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kricketot PokemonInstance Class
	#region Kricketot
	public class Kricketot : PokemonInstance
	{
		#region Kricketot Constructors
		/// <summary>
		/// Kricketot Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Kricketot(string nickname, int level)
		: base(
				KricketotSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kricketot Constructor only waiting for a Level
		/// </summary>
		public Kricketot(int level)
		: this( "Kricketot", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kricketot Constructor waiting for no params
		/// </summary>
		/*
		public Kricketot() : this( "Kricketot", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}