using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hoopa PokemonInstance Class
	#region Hoopa
	public class Hoopa : PokemonInstance
	{
		#region Hoopa Constructors
		/// <summary>
		/// Hoopa Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Hoopa(string nickname, int level)
		: base(
				HoopaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoopa Constructor only waiting for a Level
		/// </summary>
		public Hoopa(int level)
		: this( "Hoopa", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoopa Constructor waiting for no params
		/// </summary>
		/*
		public Hoopa() : this( "Hoopa", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}