using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Toucannon PokemonInstance Class
	#region Toucannon
	public class Toucannon : PokemonInstance
	{
		#region Toucannon Constructors
		/// <summary>
		/// Toucannon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Toucannon(string nickname, int level)
		: base(
				ToucannonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toucannon Constructor only waiting for a Level
		/// </summary>
		public Toucannon(int level)
		: this( "Toucannon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toucannon Constructor waiting for no params
		/// </summary>
		/*
		public Toucannon() : this( "Toucannon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}