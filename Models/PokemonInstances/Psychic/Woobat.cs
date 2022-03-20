using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Woobat PokemonInstance Class
	#region Woobat
	public class Woobat : PokemonInstance
	{
		#region Woobat Constructors
		/// <summary>
		/// Woobat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Woobat(string nickname, int level)
		: base(
				WoobatSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Woobat Constructor only waiting for a Level
		/// </summary>
		public Woobat(int level)
		: this( "Woobat", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Woobat Constructor waiting for no params
		/// </summary>
		/*
		public Woobat() : this( "Woobat", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}