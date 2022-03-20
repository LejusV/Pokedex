using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gastly PokemonInstance Class
	#region Gastly
	public class Gastly : PokemonInstance
	{
		#region Gastly Constructors
		/// <summary>
		/// Gastly Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gastly(string nickname, int level)
		: base(
				GastlySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gastly Constructor only waiting for a Level
		/// </summary>
		public Gastly(int level)
		: this( "Gastly", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gastly Constructor waiting for no params
		/// </summary>
		/*
		public Gastly() : this( "Gastly", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}