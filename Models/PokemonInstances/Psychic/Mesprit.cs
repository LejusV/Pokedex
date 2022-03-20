using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mesprit PokemonInstance Class
	#region Mesprit
	public class Mesprit : PokemonInstance
	{
		#region Mesprit Constructors
		/// <summary>
		/// Mesprit Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mesprit(string nickname, int level)
		: base(
				MespritSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mesprit Constructor only waiting for a Level
		/// </summary>
		public Mesprit(int level)
		: this( "Mesprit", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mesprit Constructor waiting for no params
		/// </summary>
		/*
		public Mesprit() : this( "Mesprit", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}