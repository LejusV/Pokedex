using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Slugma PokemonInstance Class
	#region Slugma
	public class Slugma : PokemonInstance
	{
		#region Slugma Constructors
		/// <summary>
		/// Slugma Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Slugma(string nickname, int level)
		: base(
				SlugmaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slugma Constructor only waiting for a Level
		/// </summary>
		public Slugma(int level)
		: this( "Slugma", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slugma Constructor waiting for no params
		/// </summary>
		/*
		public Slugma() : this( "Slugma", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}