using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Thwackey PokemonInstance Class
	#region Thwackey
	public class Thwackey : PokemonInstance
	{
		#region Thwackey Constructors
		/// <summary>
		/// Thwackey Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Thwackey(string nickname, int level)
		: base(
				ThwackeySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thwackey Constructor only waiting for a Level
		/// </summary>
		public Thwackey(int level)
		: this( "Thwackey", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thwackey Constructor waiting for no params
		/// </summary>
		/*
		public Thwackey() : this( "Thwackey", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}