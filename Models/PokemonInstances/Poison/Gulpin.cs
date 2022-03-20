using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gulpin PokemonInstance Class
	#region Gulpin
	public class Gulpin : PokemonInstance
	{
		#region Gulpin Constructors
		/// <summary>
		/// Gulpin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gulpin(string nickname, int level)
		: base(
				GulpinSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gulpin Constructor only waiting for a Level
		/// </summary>
		public Gulpin(int level)
		: this( "Gulpin", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gulpin Constructor waiting for no params
		/// </summary>
		/*
		public Gulpin() : this( "Gulpin", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}