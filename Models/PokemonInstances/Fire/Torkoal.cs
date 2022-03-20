using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Torkoal PokemonInstance Class
	#region Torkoal
	public class Torkoal : PokemonInstance
	{
		#region Torkoal Constructors
		/// <summary>
		/// Torkoal Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Torkoal(string nickname, int level)
		: base(
				TorkoalSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torkoal Constructor only waiting for a Level
		/// </summary>
		public Torkoal(int level)
		: this( "Torkoal", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torkoal Constructor waiting for no params
		/// </summary>
		/*
		public Torkoal() : this( "Torkoal", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}