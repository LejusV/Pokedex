using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Donphan PokemonInstance Class
	#region Donphan
	public class Donphan : PokemonInstance
	{
		#region Donphan Constructors
		/// <summary>
		/// Donphan Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Donphan(string nickname, int level)
		: base(
				DonphanSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Donphan Constructor only waiting for a Level
		/// </summary>
		public Donphan(int level)
		: this( "Donphan", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Donphan Constructor waiting for no params
		/// </summary>
		/*
		public Donphan() : this( "Donphan", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}