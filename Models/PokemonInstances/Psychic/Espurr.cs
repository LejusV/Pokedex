using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Espurr PokemonInstance Class
	#region Espurr
	public class Espurr : PokemonInstance
	{
		#region Espurr Constructors
		/// <summary>
		/// Espurr Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Espurr(string nickname, int level)
		: base(
				EspurrSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Espurr Constructor only waiting for a Level
		/// </summary>
		public Espurr(int level)
		: this( "Espurr", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Espurr Constructor waiting for no params
		/// </summary>
		/*
		public Espurr() : this( "Espurr", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}