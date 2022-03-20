using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Manectric PokemonInstance Class
	#region Manectric
	public class Manectric : PokemonInstance
	{
		#region Manectric Constructors
		/// <summary>
		/// Manectric Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Manectric(string nickname, int level)
		: base(
				ManectricSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Manectric Constructor only waiting for a Level
		/// </summary>
		public Manectric(int level)
		: this( "Manectric", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Manectric Constructor waiting for no params
		/// </summary>
		/*
		public Manectric() : this( "Manectric", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}