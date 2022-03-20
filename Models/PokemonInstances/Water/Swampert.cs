using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Swampert PokemonInstance Class
	#region Swampert
	public class Swampert : PokemonInstance
	{
		#region Swampert Constructors
		/// <summary>
		/// Swampert Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Swampert(string nickname, int level)
		: base(
				SwampertSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swampert Constructor only waiting for a Level
		/// </summary>
		public Swampert(int level)
		: this( "Swampert", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swampert Constructor waiting for no params
		/// </summary>
		/*
		public Swampert() : this( "Swampert", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}