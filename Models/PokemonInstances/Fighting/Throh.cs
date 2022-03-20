using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Throh PokemonInstance Class
	#region Throh
	public class Throh : PokemonInstance
	{
		#region Throh Constructors
		/// <summary>
		/// Throh Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Throh(string nickname, int level)
		: base(
				ThrohSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Throh Constructor only waiting for a Level
		/// </summary>
		public Throh(int level)
		: this( "Throh", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Throh Constructor waiting for no params
		/// </summary>
		/*
		public Throh() : this( "Throh", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}