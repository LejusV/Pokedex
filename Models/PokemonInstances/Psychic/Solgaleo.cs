using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Solgaleo PokemonInstance Class
	#region Solgaleo
	public class Solgaleo : PokemonInstance
	{
		#region Solgaleo Constructors
		/// <summary>
		/// Solgaleo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Solgaleo(string nickname, int level)
		: base(
				SolgaleoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solgaleo Constructor only waiting for a Level
		/// </summary>
		public Solgaleo(int level)
		: this( "Solgaleo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solgaleo Constructor waiting for no params
		/// </summary>
		/*
		public Solgaleo() : this( "Solgaleo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}