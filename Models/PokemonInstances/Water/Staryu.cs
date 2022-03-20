using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Staryu PokemonInstance Class
	#region Staryu
	public class Staryu : PokemonInstance
	{
		#region Staryu Constructors
		/// <summary>
		/// Staryu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Staryu(string nickname, int level)
		: base(
				StaryuSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staryu Constructor only waiting for a Level
		/// </summary>
		public Staryu(int level)
		: this( "Staryu", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staryu Constructor waiting for no params
		/// </summary>
		/*
		public Staryu() : this( "Staryu", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}