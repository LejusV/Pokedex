using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hattrem PokemonInstance Class
	#region Hattrem
	public class Hattrem : PokemonInstance
	{
		#region Hattrem Constructors
		/// <summary>
		/// Hattrem Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Hattrem(string nickname, int level)
		: base(
				HattremSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hattrem Constructor only waiting for a Level
		/// </summary>
		public Hattrem(int level)
		: this( "Hattrem", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hattrem Constructor waiting for no params
		/// </summary>
		/*
		public Hattrem() : this( "Hattrem", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}