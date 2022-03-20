using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mankey PokemonInstance Class
	#region Mankey
	public class Mankey : PokemonInstance
	{
		#region Mankey Constructors
		/// <summary>
		/// Mankey Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mankey(string nickname, int level)
		: base(
				MankeySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mankey Constructor only waiting for a Level
		/// </summary>
		public Mankey(int level)
		: this( "Mankey", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mankey Constructor waiting for no params
		/// </summary>
		/*
		public Mankey() : this( "Mankey", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}