using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Vanillish PokemonInstance Class
	#region Vanillish
	public class Vanillish : PokemonInstance
	{
		#region Vanillish Constructors
		/// <summary>
		/// Vanillish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Vanillish(string nickname, int level)
		: base(
				VanillishSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanillish Constructor only waiting for a Level
		/// </summary>
		public Vanillish(int level)
		: this( "Vanillish", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanillish Constructor waiting for no params
		/// </summary>
		/*
		public Vanillish() : this( "Vanillish", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}