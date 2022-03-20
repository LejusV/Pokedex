using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Whiscash PokemonInstance Class
	#region Whiscash
	public class Whiscash : PokemonInstance
	{
		#region Whiscash Constructors
		/// <summary>
		/// Whiscash Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Whiscash(string nickname, int level)
		: base(
				WhiscashSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whiscash Constructor only waiting for a Level
		/// </summary>
		public Whiscash(int level)
		: this( "Whiscash", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whiscash Constructor waiting for no params
		/// </summary>
		/*
		public Whiscash() : this( "Whiscash", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}