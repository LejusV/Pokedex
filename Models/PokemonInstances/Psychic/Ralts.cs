using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ralts PokemonInstance Class
	#region Ralts
	public class Ralts : PokemonInstance
	{
		#region Ralts Constructors
		/// <summary>
		/// Ralts Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ralts(string nickname, int level)
		: base(
				RaltsSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ralts Constructor only waiting for a Level
		/// </summary>
		public Ralts(int level)
		: this( "Ralts", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ralts Constructor waiting for no params
		/// </summary>
		/*
		public Ralts() : this( "Ralts", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}