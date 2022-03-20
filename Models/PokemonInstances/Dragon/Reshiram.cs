using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Reshiram PokemonInstance Class
	#region Reshiram
	public class Reshiram : PokemonInstance
	{
		#region Reshiram Constructors
		/// <summary>
		/// Reshiram Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Reshiram(string nickname, int level)
		: base(
				ReshiramSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Reshiram Constructor only waiting for a Level
		/// </summary>
		public Reshiram(int level)
		: this( "Reshiram", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Reshiram Constructor waiting for no params
		/// </summary>
		/*
		public Reshiram() : this( "Reshiram", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}