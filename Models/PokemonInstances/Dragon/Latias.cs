using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Latias PokemonInstance Class
	#region Latias
	public class Latias : PokemonInstance
	{
		#region Latias Constructors
		/// <summary>
		/// Latias Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Latias(string nickname, int level)
		: base(
				LatiasSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Latias Constructor only waiting for a Level
		/// </summary>
		public Latias(int level)
		: this( "Latias", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Latias Constructor waiting for no params
		/// </summary>
		/*
		public Latias() : this( "Latias", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}