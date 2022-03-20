using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Shiftry PokemonInstance Class
	#region Shiftry
	public class Shiftry : PokemonInstance
	{
		#region Shiftry Constructors
		/// <summary>
		/// Shiftry Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Shiftry(string nickname, int level)
		: base(
				ShiftrySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shiftry Constructor only waiting for a Level
		/// </summary>
		public Shiftry(int level)
		: this( "Shiftry", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shiftry Constructor waiting for no params
		/// </summary>
		/*
		public Shiftry() : this( "Shiftry", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}