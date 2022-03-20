using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Herdier PokemonInstance Class
	#region Herdier
	public class Herdier : PokemonInstance
	{
		#region Herdier Constructors
		/// <summary>
		/// Herdier Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Herdier(string nickname, int level)
		: base(
				HerdierSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Herdier Constructor only waiting for a Level
		/// </summary>
		public Herdier(int level)
		: this( "Herdier", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Herdier Constructor waiting for no params
		/// </summary>
		/*
		public Herdier() : this( "Herdier", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}