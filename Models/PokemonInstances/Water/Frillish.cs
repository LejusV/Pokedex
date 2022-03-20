using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Frillish PokemonInstance Class
	#region Frillish
	public class Frillish : PokemonInstance
	{
		#region Frillish Constructors
		/// <summary>
		/// Frillish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Frillish(string nickname, int level)
		: base(
				FrillishSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frillish Constructor only waiting for a Level
		/// </summary>
		public Frillish(int level)
		: this( "Frillish", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frillish Constructor waiting for no params
		/// </summary>
		/*
		public Frillish() : this( "Frillish", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}