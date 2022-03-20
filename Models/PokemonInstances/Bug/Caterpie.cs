using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Caterpie PokemonInstance Class
	#region Caterpie
	public class Caterpie : PokemonInstance
	{
		#region Caterpie Constructors
		/// <summary>
		/// Caterpie Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Caterpie(string nickname, int level)
		: base(
				CaterpieSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Caterpie Constructor only waiting for a Level
		/// </summary>
		public Caterpie(int level)
		: this( "Caterpie", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Caterpie Constructor waiting for no params
		/// </summary>
		/*
		public Caterpie() : this( "Caterpie", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}