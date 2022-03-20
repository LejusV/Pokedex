using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Oddish PokemonInstance Class
	#region Oddish
	public class Oddish : PokemonInstance
	{
		#region Oddish Constructors
		/// <summary>
		/// Oddish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Oddish(string nickname, int level)
		: base(
				OddishSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oddish Constructor only waiting for a Level
		/// </summary>
		public Oddish(int level)
		: this( "Oddish", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oddish Constructor waiting for no params
		/// </summary>
		/*
		public Oddish() : this( "Oddish", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}