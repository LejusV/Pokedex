using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Krokorok PokemonInstance Class
	#region Krokorok
	public class Krokorok : PokemonInstance
	{
		#region Krokorok Constructors
		/// <summary>
		/// Krokorok Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Krokorok(string nickname, int level)
		: base(
				KrokorokSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krokorok Constructor only waiting for a Level
		/// </summary>
		public Krokorok(int level)
		: this( "Krokorok", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krokorok Constructor waiting for no params
		/// </summary>
		/*
		public Krokorok() : this( "Krokorok", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}