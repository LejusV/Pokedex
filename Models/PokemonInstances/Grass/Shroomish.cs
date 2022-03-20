using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Shroomish PokemonInstance Class
	#region Shroomish
	public class Shroomish : PokemonInstance
	{
		#region Shroomish Constructors
		/// <summary>
		/// Shroomish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Shroomish(string nickname, int level)
		: base(
				ShroomishSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shroomish Constructor only waiting for a Level
		/// </summary>
		public Shroomish(int level)
		: this( "Shroomish", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shroomish Constructor waiting for no params
		/// </summary>
		/*
		public Shroomish() : this( "Shroomish", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}