using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Seedot PokemonInstance Class
	#region Seedot
	public class Seedot : PokemonInstance
	{
		#region Seedot Constructors
		/// <summary>
		/// Seedot Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Seedot(string nickname, int level)
		: base(
				SeedotSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seedot Constructor only waiting for a Level
		/// </summary>
		public Seedot(int level)
		: this( "Seedot", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seedot Constructor waiting for no params
		/// </summary>
		/*
		public Seedot() : this( "Seedot", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}