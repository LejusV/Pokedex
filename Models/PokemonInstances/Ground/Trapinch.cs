using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Trapinch PokemonInstance Class
	#region Trapinch
	public class Trapinch : PokemonInstance
	{
		#region Trapinch Constructors
		/// <summary>
		/// Trapinch Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Trapinch(string nickname, int level)
		: base(
				TrapinchSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trapinch Constructor only waiting for a Level
		/// </summary>
		public Trapinch(int level)
		: this( "Trapinch", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trapinch Constructor waiting for no params
		/// </summary>
		/*
		public Trapinch() : this( "Trapinch", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}