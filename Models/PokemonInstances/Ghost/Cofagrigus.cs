using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cofagrigus PokemonInstance Class
	#region Cofagrigus
	public class Cofagrigus : PokemonInstance
	{
		#region Cofagrigus Constructors
		/// <summary>
		/// Cofagrigus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cofagrigus(string nickname, int level)
		: base(
				CofagrigusSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cofagrigus Constructor only waiting for a Level
		/// </summary>
		public Cofagrigus(int level)
		: this( "Cofagrigus", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cofagrigus Constructor waiting for no params
		/// </summary>
		/*
		public Cofagrigus() : this( "Cofagrigus", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}