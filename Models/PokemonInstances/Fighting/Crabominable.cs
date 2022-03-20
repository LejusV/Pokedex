using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Crabominable PokemonInstance Class
	#region Crabominable
	public class Crabominable : PokemonInstance
	{
		#region Crabominable Constructors
		/// <summary>
		/// Crabominable Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Crabominable(string nickname, int level)
		: base(
				CrabominableSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crabominable Constructor only waiting for a Level
		/// </summary>
		public Crabominable(int level)
		: this( "Crabominable", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crabominable Constructor waiting for no params
		/// </summary>
		/*
		public Crabominable() : this( "Crabominable", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}