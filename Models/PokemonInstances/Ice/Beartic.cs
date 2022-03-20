using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Beartic PokemonInstance Class
	#region Beartic
	public class Beartic : PokemonInstance
	{
		#region Beartic Constructors
		/// <summary>
		/// Beartic Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Beartic(string nickname, int level)
		: base(
				BearticSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beartic Constructor only waiting for a Level
		/// </summary>
		public Beartic(int level)
		: this( "Beartic", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beartic Constructor waiting for no params
		/// </summary>
		/*
		public Beartic() : this( "Beartic", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}