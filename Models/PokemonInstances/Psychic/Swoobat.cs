using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Swoobat PokemonInstance Class
	#region Swoobat
	public class Swoobat : PokemonInstance
	{
		#region Swoobat Constructors
		/// <summary>
		/// Swoobat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Swoobat(string nickname, int level)
		: base(
				SwoobatSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swoobat Constructor only waiting for a Level
		/// </summary>
		public Swoobat(int level)
		: this( "Swoobat", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swoobat Constructor waiting for no params
		/// </summary>
		/*
		public Swoobat() : this( "Swoobat", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}