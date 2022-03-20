using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Yanma PokemonInstance Class
	#region Yanma
	public class Yanma : PokemonInstance
	{
		#region Yanma Constructors
		/// <summary>
		/// Yanma Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Yanma(string nickname, int level)
		: base(
				YanmaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yanma Constructor only waiting for a Level
		/// </summary>
		public Yanma(int level)
		: this( "Yanma", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yanma Constructor waiting for no params
		/// </summary>
		/*
		public Yanma() : this( "Yanma", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}