using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Froakie PokemonInstance Class
	#region Froakie
	public class Froakie : PokemonInstance
	{
		#region Froakie Constructors
		/// <summary>
		/// Froakie Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Froakie(string nickname, int level)
		: base(
				FroakieSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Froakie Constructor only waiting for a Level
		/// </summary>
		public Froakie(int level)
		: this( "Froakie", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Froakie Constructor waiting for no params
		/// </summary>
		/*
		public Froakie() : this( "Froakie", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}