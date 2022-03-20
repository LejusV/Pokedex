using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Seismitoad PokemonInstance Class
	#region Seismitoad
	public class Seismitoad : PokemonInstance
	{
		#region Seismitoad Constructors
		/// <summary>
		/// Seismitoad Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Seismitoad(string nickname, int level)
		: base(
				SeismitoadSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seismitoad Constructor only waiting for a Level
		/// </summary>
		public Seismitoad(int level)
		: this( "Seismitoad", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seismitoad Constructor waiting for no params
		/// </summary>
		/*
		public Seismitoad() : this( "Seismitoad", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}