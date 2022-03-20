using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Prinplup PokemonInstance Class
	#region Prinplup
	public class Prinplup : PokemonInstance
	{
		#region Prinplup Constructors
		/// <summary>
		/// Prinplup Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Prinplup(string nickname, int level)
		: base(
				PrinplupSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Prinplup Constructor only waiting for a Level
		/// </summary>
		public Prinplup(int level)
		: this( "Prinplup", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Prinplup Constructor waiting for no params
		/// </summary>
		/*
		public Prinplup() : this( "Prinplup", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}