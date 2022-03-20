using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Zubat PokemonInstance Class
	#region Zubat
	public class Zubat : PokemonInstance
	{
		#region Zubat Constructors
		/// <summary>
		/// Zubat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Zubat(string nickname, int level)
		: base(
				ZubatSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zubat Constructor only waiting for a Level
		/// </summary>
		public Zubat(int level)
		: this( "Zubat", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zubat Constructor waiting for no params
		/// </summary>
		/*
		public Zubat() : this( "Zubat", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}