using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Conkeldurr PokemonInstance Class
	#region Conkeldurr
	public class Conkeldurr : PokemonInstance
	{
		#region Conkeldurr Constructors
		/// <summary>
		/// Conkeldurr Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Conkeldurr(string nickname, int level)
		: base(
				ConkeldurrSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Conkeldurr Constructor only waiting for a Level
		/// </summary>
		public Conkeldurr(int level)
		: this( "Conkeldurr", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Conkeldurr Constructor waiting for no params
		/// </summary>
		/*
		public Conkeldurr() : this( "Conkeldurr", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}