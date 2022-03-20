using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lilligant PokemonInstance Class
	#region Lilligant
	public class Lilligant : PokemonInstance
	{
		#region Lilligant Constructors
		/// <summary>
		/// Lilligant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lilligant(string nickname, int level)
		: base(
				LilligantSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lilligant Constructor only waiting for a Level
		/// </summary>
		public Lilligant(int level)
		: this( "Lilligant", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lilligant Constructor waiting for no params
		/// </summary>
		/*
		public Lilligant() : this( "Lilligant", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}