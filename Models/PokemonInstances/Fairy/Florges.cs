using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Florges PokemonInstance Class
	#region Florges
	public class Florges : PokemonInstance
	{
		#region Florges Constructors
		/// <summary>
		/// Florges Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Florges(string nickname, int level)
		: base(
				FlorgesSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Florges Constructor only waiting for a Level
		/// </summary>
		public Florges(int level)
		: this( "Florges", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Florges Constructor waiting for no params
		/// </summary>
		/*
		public Florges() : this( "Florges", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}