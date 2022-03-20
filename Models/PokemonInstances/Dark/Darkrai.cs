using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Darkrai PokemonInstance Class
	#region Darkrai
	public class Darkrai : PokemonInstance
	{
		#region Darkrai Constructors
		/// <summary>
		/// Darkrai Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Darkrai(string nickname, int level)
		: base(
				DarkraiSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darkrai Constructor only waiting for a Level
		/// </summary>
		public Darkrai(int level)
		: this( "Darkrai", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darkrai Constructor waiting for no params
		/// </summary>
		/*
		public Darkrai() : this( "Darkrai", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}