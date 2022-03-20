using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Illumise PokemonInstance Class
	#region Illumise
	public class Illumise : PokemonInstance
	{
		#region Illumise Constructors
		/// <summary>
		/// Illumise Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Illumise(string nickname, int level)
		: base(
				IllumiseSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Illumise Constructor only waiting for a Level
		/// </summary>
		public Illumise(int level)
		: this( "Illumise", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Illumise Constructor waiting for no params
		/// </summary>
		/*
		public Illumise() : this( "Illumise", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}