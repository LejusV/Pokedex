using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Trubbish PokemonInstance Class
	#region Trubbish
	public class Trubbish : PokemonInstance
	{
		#region Trubbish Constructors
		/// <summary>
		/// Trubbish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Trubbish(string nickname, int level)
		: base(
				TrubbishSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trubbish Constructor only waiting for a Level
		/// </summary>
		public Trubbish(int level)
		: this( "Trubbish", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trubbish Constructor waiting for no params
		/// </summary>
		/*
		public Trubbish() : this( "Trubbish", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}