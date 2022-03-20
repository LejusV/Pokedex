using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tangrowth PokemonInstance Class
	#region Tangrowth
	public class Tangrowth : PokemonInstance
	{
		#region Tangrowth Constructors
		/// <summary>
		/// Tangrowth Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tangrowth(string nickname, int level)
		: base(
				TangrowthSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tangrowth Constructor only waiting for a Level
		/// </summary>
		public Tangrowth(int level)
		: this( "Tangrowth", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tangrowth Constructor waiting for no params
		/// </summary>
		/*
		public Tangrowth() : this( "Tangrowth", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}