using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Vileplume PokemonInstance Class
	#region Vileplume
	public class Vileplume : PokemonInstance
	{
		#region Vileplume Constructors
		/// <summary>
		/// Vileplume Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Vileplume(string nickname, int level)
		: base(
				VileplumeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vileplume Constructor only waiting for a Level
		/// </summary>
		public Vileplume(int level)
		: this( "Vileplume", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vileplume Constructor waiting for no params
		/// </summary>
		/*
		public Vileplume() : this( "Vileplume", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}