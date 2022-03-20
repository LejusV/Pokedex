using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Stufful PokemonInstance Class
	#region Stufful
	public class Stufful : PokemonInstance
	{
		#region Stufful Constructors
		/// <summary>
		/// Stufful Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Stufful(string nickname, int level)
		: base(
				StuffulSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stufful Constructor only waiting for a Level
		/// </summary>
		public Stufful(int level)
		: this( "Stufful", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stufful Constructor waiting for no params
		/// </summary>
		/*
		public Stufful() : this( "Stufful", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}