using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dracovish PokemonInstance Class
	#region Dracovish
	public class Dracovish : PokemonInstance
	{
		#region Dracovish Constructors
		/// <summary>
		/// Dracovish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dracovish(string nickname, int level)
		: base(
				DracovishSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dracovish Constructor only waiting for a Level
		/// </summary>
		public Dracovish(int level)
		: this( "Dracovish", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dracovish Constructor waiting for no params
		/// </summary>
		/*
		public Dracovish() : this( "Dracovish", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}