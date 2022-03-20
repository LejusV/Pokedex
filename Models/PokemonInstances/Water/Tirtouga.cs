using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tirtouga PokemonInstance Class
	#region Tirtouga
	public class Tirtouga : PokemonInstance
	{
		#region Tirtouga Constructors
		/// <summary>
		/// Tirtouga Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tirtouga(string nickname, int level)
		: base(
				TirtougaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tirtouga Constructor only waiting for a Level
		/// </summary>
		public Tirtouga(int level)
		: this( "Tirtouga", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tirtouga Constructor waiting for no params
		/// </summary>
		/*
		public Tirtouga() : this( "Tirtouga", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}