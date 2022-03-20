using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mightyena PokemonInstance Class
	#region Mightyena
	public class Mightyena : PokemonInstance
	{
		#region Mightyena Constructors
		/// <summary>
		/// Mightyena Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mightyena(string nickname, int level)
		: base(
				MightyenaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mightyena Constructor only waiting for a Level
		/// </summary>
		public Mightyena(int level)
		: this( "Mightyena", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mightyena Constructor waiting for no params
		/// </summary>
		/*
		public Mightyena() : this( "Mightyena", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}