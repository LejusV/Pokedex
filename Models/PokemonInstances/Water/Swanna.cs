using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Swanna PokemonInstance Class
	#region Swanna
	public class Swanna : PokemonInstance
	{
		#region Swanna Constructors
		/// <summary>
		/// Swanna Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Swanna(string nickname, int level)
		: base(
				SwannaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swanna Constructor only waiting for a Level
		/// </summary>
		public Swanna(int level)
		: this( "Swanna", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swanna Constructor waiting for no params
		/// </summary>
		/*
		public Swanna() : this( "Swanna", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}