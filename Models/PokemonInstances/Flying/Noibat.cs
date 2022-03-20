using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Noibat PokemonInstance Class
	#region Noibat
	public class Noibat : PokemonInstance
	{
		#region Noibat Constructors
		/// <summary>
		/// Noibat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Noibat(string nickname, int level)
		: base(
				NoibatSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noibat Constructor only waiting for a Level
		/// </summary>
		public Noibat(int level)
		: this( "Noibat", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noibat Constructor waiting for no params
		/// </summary>
		/*
		public Noibat() : this( "Noibat", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}