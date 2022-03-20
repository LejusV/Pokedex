using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lickitung PokemonInstance Class
	#region Lickitung
	public class Lickitung : PokemonInstance
	{
		#region Lickitung Constructors
		/// <summary>
		/// Lickitung Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lickitung(string nickname, int level)
		: base(
				LickitungSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lickitung Constructor only waiting for a Level
		/// </summary>
		public Lickitung(int level)
		: this( "Lickitung", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lickitung Constructor waiting for no params
		/// </summary>
		/*
		public Lickitung() : this( "Lickitung", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}