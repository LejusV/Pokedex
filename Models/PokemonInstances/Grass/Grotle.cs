using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Grotle PokemonInstance Class
	#region Grotle
	public class Grotle : PokemonInstance
	{
		#region Grotle Constructors
		/// <summary>
		/// Grotle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Grotle(string nickname, int level)
		: base(
				GrotleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grotle Constructor only waiting for a Level
		/// </summary>
		public Grotle(int level)
		: this( "Grotle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grotle Constructor waiting for no params
		/// </summary>
		/*
		public Grotle() : this( "Grotle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}