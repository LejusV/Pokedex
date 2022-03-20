using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Graveler PokemonInstance Class
	#region Graveler
	public class Graveler : PokemonInstance
	{
		#region Graveler Constructors
		/// <summary>
		/// Graveler Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Graveler(string nickname, int level)
		: base(
				GravelerSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Graveler Constructor only waiting for a Level
		/// </summary>
		public Graveler(int level)
		: this( "Graveler", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Graveler Constructor waiting for no params
		/// </summary>
		/*
		public Graveler() : this( "Graveler", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}