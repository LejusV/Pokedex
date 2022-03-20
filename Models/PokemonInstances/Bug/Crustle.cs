using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Crustle PokemonInstance Class
	#region Crustle
	public class Crustle : PokemonInstance
	{
		#region Crustle Constructors
		/// <summary>
		/// Crustle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Crustle(string nickname, int level)
		: base(
				CrustleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crustle Constructor only waiting for a Level
		/// </summary>
		public Crustle(int level)
		: this( "Crustle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crustle Constructor waiting for no params
		/// </summary>
		/*
		public Crustle() : this( "Crustle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}