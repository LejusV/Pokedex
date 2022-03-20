using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Garbodor PokemonInstance Class
	#region Garbodor
	public class Garbodor : PokemonInstance
	{
		#region Garbodor Constructors
		/// <summary>
		/// Garbodor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Garbodor(string nickname, int level)
		: base(
				GarbodorSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Garbodor Constructor only waiting for a Level
		/// </summary>
		public Garbodor(int level)
		: this( "Garbodor", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Garbodor Constructor waiting for no params
		/// </summary>
		/*
		public Garbodor() : this( "Garbodor", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}