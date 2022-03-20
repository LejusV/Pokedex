using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Shellos PokemonInstance Class
	#region Shellos
	public class Shellos : PokemonInstance
	{
		#region Shellos Constructors
		/// <summary>
		/// Shellos Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Shellos(string nickname, int level)
		: base(
				ShellosSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shellos Constructor only waiting for a Level
		/// </summary>
		public Shellos(int level)
		: this( "Shellos", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shellos Constructor waiting for no params
		/// </summary>
		/*
		public Shellos() : this( "Shellos", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}