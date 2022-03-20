using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Snom PokemonInstance Class
	#region Snom
	public class Snom : PokemonInstance
	{
		#region Snom Constructors
		/// <summary>
		/// Snom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Snom(string nickname, int level)
		: base(
				SnomSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snom Constructor only waiting for a Level
		/// </summary>
		public Snom(int level)
		: this( "Snom", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snom Constructor waiting for no params
		/// </summary>
		/*
		public Snom() : this( "Snom", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}