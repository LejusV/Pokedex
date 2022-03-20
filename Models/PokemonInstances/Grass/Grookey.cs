using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Grookey PokemonInstance Class
	#region Grookey
	public class Grookey : PokemonInstance
	{
		#region Grookey Constructors
		/// <summary>
		/// Grookey Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Grookey(string nickname, int level)
		: base(
				GrookeySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grookey Constructor only waiting for a Level
		/// </summary>
		public Grookey(int level)
		: this( "Grookey", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grookey Constructor waiting for no params
		/// </summary>
		/*
		public Grookey() : this( "Grookey", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}