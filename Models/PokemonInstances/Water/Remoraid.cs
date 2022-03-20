using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Remoraid PokemonInstance Class
	#region Remoraid
	public class Remoraid : PokemonInstance
	{
		#region Remoraid Constructors
		/// <summary>
		/// Remoraid Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Remoraid(string nickname, int level)
		: base(
				RemoraidSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Remoraid Constructor only waiting for a Level
		/// </summary>
		public Remoraid(int level)
		: this( "Remoraid", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Remoraid Constructor waiting for no params
		/// </summary>
		/*
		public Remoraid() : this( "Remoraid", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}