using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kakuna PokemonInstance Class
	#region Kakuna
	public class Kakuna : PokemonInstance
	{
		#region Kakuna Constructors
		/// <summary>
		/// Kakuna Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Kakuna(string nickname, int level)
		: base(
				KakunaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kakuna Constructor only waiting for a Level
		/// </summary>
		public Kakuna(int level)
		: this( "Kakuna", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kakuna Constructor waiting for no params
		/// </summary>
		/*
		public Kakuna() : this( "Kakuna", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}