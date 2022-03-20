using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Magneton PokemonInstance Class
	#region Magneton
	public class Magneton : PokemonInstance
	{
		#region Magneton Constructors
		/// <summary>
		/// Magneton Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Magneton(string nickname, int level)
		: base(
				MagnetonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magneton Constructor only waiting for a Level
		/// </summary>
		public Magneton(int level)
		: this( "Magneton", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magneton Constructor waiting for no params
		/// </summary>
		/*
		public Magneton() : this( "Magneton", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}