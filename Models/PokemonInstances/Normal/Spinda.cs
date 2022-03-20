using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Spinda PokemonInstance Class
	#region Spinda
	public class Spinda : PokemonInstance
	{
		#region Spinda Constructors
		/// <summary>
		/// Spinda Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Spinda(string nickname, int level)
		: base(
				SpindaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spinda Constructor only waiting for a Level
		/// </summary>
		public Spinda(int level)
		: this( "Spinda", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spinda Constructor waiting for no params
		/// </summary>
		/*
		public Spinda() : this( "Spinda", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}