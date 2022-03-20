using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pansage PokemonInstance Class
	#region Pansage
	public class Pansage : PokemonInstance
	{
		#region Pansage Constructors
		/// <summary>
		/// Pansage Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pansage(string nickname, int level)
		: base(
				PansageSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pansage Constructor only waiting for a Level
		/// </summary>
		public Pansage(int level)
		: this( "Pansage", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pansage Constructor waiting for no params
		/// </summary>
		/*
		public Pansage() : this( "Pansage", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}