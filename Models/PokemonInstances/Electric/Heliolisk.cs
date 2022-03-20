using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Heliolisk PokemonInstance Class
	#region Heliolisk
	public class Heliolisk : PokemonInstance
	{
		#region Heliolisk Constructors
		/// <summary>
		/// Heliolisk Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Heliolisk(string nickname, int level)
		: base(
				HelioliskSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heliolisk Constructor only waiting for a Level
		/// </summary>
		public Heliolisk(int level)
		: this( "Heliolisk", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heliolisk Constructor waiting for no params
		/// </summary>
		/*
		public Heliolisk() : this( "Heliolisk", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}