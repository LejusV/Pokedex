using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Greedent PokemonInstance Class
	#region Greedent
	public class Greedent : PokemonInstance
	{
		#region Greedent Constructors
		/// <summary>
		/// Greedent Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Greedent(string nickname, int level)
		: base(
				GreedentSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Greedent Constructor only waiting for a Level
		/// </summary>
		public Greedent(int level)
		: this( "Greedent", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Greedent Constructor waiting for no params
		/// </summary>
		/*
		public Greedent() : this( "Greedent", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}