using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Skarmory PokemonInstance Class
	#region Skarmory
	public class Skarmory : PokemonInstance
	{
		#region Skarmory Constructors
		/// <summary>
		/// Skarmory Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Skarmory(string nickname, int level)
		: base(
				SkarmorySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skarmory Constructor only waiting for a Level
		/// </summary>
		public Skarmory(int level)
		: this( "Skarmory", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skarmory Constructor waiting for no params
		/// </summary>
		/*
		public Skarmory() : this( "Skarmory", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}