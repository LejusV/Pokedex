using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mareep PokemonInstance Class
	#region Mareep
	public class Mareep : PokemonInstance
	{
		#region Mareep Constructors
		/// <summary>
		/// Mareep Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mareep(string nickname, int level)
		: base(
				MareepSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mareep Constructor only waiting for a Level
		/// </summary>
		public Mareep(int level)
		: this( "Mareep", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mareep Constructor waiting for no params
		/// </summary>
		/*
		public Mareep() : this( "Mareep", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}