using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Staravia PokemonInstance Class
	#region Staravia
	public class Staravia : PokemonInstance
	{
		#region Staravia Constructors
		/// <summary>
		/// Staravia Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Staravia(string nickname, int level)
		: base(
				StaraviaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staravia Constructor only waiting for a Level
		/// </summary>
		public Staravia(int level)
		: this( "Staravia", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staravia Constructor waiting for no params
		/// </summary>
		/*
		public Staravia() : this( "Staravia", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}