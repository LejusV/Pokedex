using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Calyrex PokemonInstance Class
	#region Calyrex
	public class Calyrex : PokemonInstance
	{
		#region Calyrex Constructors
		/// <summary>
		/// Calyrex Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Calyrex(string nickname, int level)
		: base(
				CalyrexSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Calyrex Constructor only waiting for a Level
		/// </summary>
		public Calyrex(int level)
		: this( "Calyrex", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Calyrex Constructor waiting for no params
		/// </summary>
		/*
		public Calyrex() : this( "Calyrex", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}