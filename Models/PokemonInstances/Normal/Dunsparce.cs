using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dunsparce PokemonInstance Class
	#region Dunsparce
	public class Dunsparce : PokemonInstance
	{
		#region Dunsparce Constructors
		/// <summary>
		/// Dunsparce Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dunsparce(string nickname, int level)
		: base(
				DunsparceSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dunsparce Constructor only waiting for a Level
		/// </summary>
		public Dunsparce(int level)
		: this( "Dunsparce", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dunsparce Constructor waiting for no params
		/// </summary>
		/*
		public Dunsparce() : this( "Dunsparce", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}