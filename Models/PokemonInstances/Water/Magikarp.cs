using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Magikarp PokemonInstance Class
	#region Magikarp
	public class Magikarp : PokemonInstance
	{
		#region Magikarp Constructors
		/// <summary>
		/// Magikarp Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Magikarp(string nickname, int level)
		: base(
				MagikarpSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magikarp Constructor only waiting for a Level
		/// </summary>
		public Magikarp(int level)
		: this( "Magikarp", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magikarp Constructor waiting for no params
		/// </summary>
		/*
		public Magikarp() : this( "Magikarp", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}