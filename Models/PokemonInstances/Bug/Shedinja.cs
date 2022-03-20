using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Shedinja PokemonInstance Class
	#region Shedinja
	public class Shedinja : PokemonInstance
	{
		#region Shedinja Constructors
		/// <summary>
		/// Shedinja Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Shedinja(string nickname, int level)
		: base(
				ShedinjaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shedinja Constructor only waiting for a Level
		/// </summary>
		public Shedinja(int level)
		: this( "Shedinja", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shedinja Constructor waiting for no params
		/// </summary>
		/*
		public Shedinja() : this( "Shedinja", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}