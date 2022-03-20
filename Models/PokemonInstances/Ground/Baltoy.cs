using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Baltoy PokemonInstance Class
	#region Baltoy
	public class Baltoy : PokemonInstance
	{
		#region Baltoy Constructors
		/// <summary>
		/// Baltoy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Baltoy(string nickname, int level)
		: base(
				BaltoySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Baltoy Constructor only waiting for a Level
		/// </summary>
		public Baltoy(int level)
		: this( "Baltoy", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Baltoy Constructor waiting for no params
		/// </summary>
		/*
		public Baltoy() : this( "Baltoy", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}