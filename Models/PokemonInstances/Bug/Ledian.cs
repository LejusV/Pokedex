using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ledian PokemonInstance Class
	#region Ledian
	public class Ledian : PokemonInstance
	{
		#region Ledian Constructors
		/// <summary>
		/// Ledian Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ledian(string nickname, int level)
		: base(
				LedianSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ledian Constructor only waiting for a Level
		/// </summary>
		public Ledian(int level)
		: this( "Ledian", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ledian Constructor waiting for no params
		/// </summary>
		/*
		public Ledian() : this( "Ledian", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}