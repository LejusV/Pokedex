using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Yanmega PokemonInstance Class
	#region Yanmega
	public class Yanmega : PokemonInstance
	{
		#region Yanmega Constructors
		/// <summary>
		/// Yanmega Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Yanmega(string nickname, int level)
		: base(
				YanmegaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yanmega Constructor only waiting for a Level
		/// </summary>
		public Yanmega(int level)
		: this( "Yanmega", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yanmega Constructor waiting for no params
		/// </summary>
		/*
		public Yanmega() : this( "Yanmega", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}