using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Vikavolt PokemonInstance Class
	#region Vikavolt
	public class Vikavolt : PokemonInstance
	{
		#region Vikavolt Constructors
		/// <summary>
		/// Vikavolt Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Vikavolt(string nickname, int level)
		: base(
				VikavoltSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vikavolt Constructor only waiting for a Level
		/// </summary>
		public Vikavolt(int level)
		: this( "Vikavolt", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vikavolt Constructor waiting for no params
		/// </summary>
		/*
		public Vikavolt() : this( "Vikavolt", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}