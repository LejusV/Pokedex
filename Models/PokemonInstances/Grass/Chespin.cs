using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Chespin PokemonInstance Class
	#region Chespin
	public class Chespin : PokemonInstance
	{
		#region Chespin Constructors
		/// <summary>
		/// Chespin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Chespin(string nickname, int level)
		: base(
				ChespinSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chespin Constructor only waiting for a Level
		/// </summary>
		public Chespin(int level)
		: this( "Chespin", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chespin Constructor waiting for no params
		/// </summary>
		/*
		public Chespin() : this( "Chespin", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}