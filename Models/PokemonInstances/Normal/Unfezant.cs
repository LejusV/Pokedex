using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Unfezant PokemonInstance Class
	#region Unfezant
	public class Unfezant : PokemonInstance
	{
		#region Unfezant Constructors
		/// <summary>
		/// Unfezant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Unfezant(string nickname, int level)
		: base(
				UnfezantSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Unfezant Constructor only waiting for a Level
		/// </summary>
		public Unfezant(int level)
		: this( "Unfezant", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Unfezant Constructor waiting for no params
		/// </summary>
		/*
		public Unfezant() : this( "Unfezant", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}