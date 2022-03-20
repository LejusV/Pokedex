using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dhelmise PokemonInstance Class
	#region Dhelmise
	public class Dhelmise : PokemonInstance
	{
		#region Dhelmise Constructors
		/// <summary>
		/// Dhelmise Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dhelmise(string nickname, int level)
		: base(
				DhelmiseSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dhelmise Constructor only waiting for a Level
		/// </summary>
		public Dhelmise(int level)
		: this( "Dhelmise", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dhelmise Constructor waiting for no params
		/// </summary>
		/*
		public Dhelmise() : this( "Dhelmise", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}