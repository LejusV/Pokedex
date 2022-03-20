using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Passimian PokemonInstance Class
	#region Passimian
	public class Passimian : PokemonInstance
	{
		#region Passimian Constructors
		/// <summary>
		/// Passimian Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Passimian(string nickname, int level)
		: base(
				PassimianSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Passimian Constructor only waiting for a Level
		/// </summary>
		public Passimian(int level)
		: this( "Passimian", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Passimian Constructor waiting for no params
		/// </summary>
		/*
		public Passimian() : this( "Passimian", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}