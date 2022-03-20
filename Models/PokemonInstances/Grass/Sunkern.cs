using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sunkern PokemonInstance Class
	#region Sunkern
	public class Sunkern : PokemonInstance
	{
		#region Sunkern Constructors
		/// <summary>
		/// Sunkern Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sunkern(string nickname, int level)
		: base(
				SunkernSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sunkern Constructor only waiting for a Level
		/// </summary>
		public Sunkern(int level)
		: this( "Sunkern", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sunkern Constructor waiting for no params
		/// </summary>
		/*
		public Sunkern() : this( "Sunkern", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}