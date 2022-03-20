using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Yveltal PokemonInstance Class
	#region Yveltal
	public class Yveltal : PokemonInstance
	{
		#region Yveltal Constructors
		/// <summary>
		/// Yveltal Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Yveltal(string nickname, int level)
		: base(
				YveltalSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yveltal Constructor only waiting for a Level
		/// </summary>
		public Yveltal(int level)
		: this( "Yveltal", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yveltal Constructor waiting for no params
		/// </summary>
		/*
		public Yveltal() : this( "Yveltal", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}