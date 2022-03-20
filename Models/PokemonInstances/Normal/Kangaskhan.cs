using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kangaskhan PokemonInstance Class
	#region Kangaskhan
	public class Kangaskhan : PokemonInstance
	{
		#region Kangaskhan Constructors
		/// <summary>
		/// Kangaskhan Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Kangaskhan(string nickname, int level)
		: base(
				KangaskhanSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kangaskhan Constructor only waiting for a Level
		/// </summary>
		public Kangaskhan(int level)
		: this( "Kangaskhan", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kangaskhan Constructor waiting for no params
		/// </summary>
		/*
		public Kangaskhan() : this( "Kangaskhan", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}