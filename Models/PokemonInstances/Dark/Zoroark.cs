using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Zoroark PokemonInstance Class
	#region Zoroark
	public class Zoroark : PokemonInstance
	{
		#region Zoroark Constructors
		/// <summary>
		/// Zoroark Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Zoroark(string nickname, int level)
		: base(
				ZoroarkSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zoroark Constructor only waiting for a Level
		/// </summary>
		public Zoroark(int level)
		: this( "Zoroark", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zoroark Constructor waiting for no params
		/// </summary>
		/*
		public Zoroark() : this( "Zoroark", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}