using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pheromosa PokemonInstance Class
	#region Pheromosa
	public class Pheromosa : PokemonInstance
	{
		#region Pheromosa Constructors
		/// <summary>
		/// Pheromosa Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pheromosa(string nickname, int level)
		: base(
				PheromosaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pheromosa Constructor only waiting for a Level
		/// </summary>
		public Pheromosa(int level)
		: this( "Pheromosa", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pheromosa Constructor waiting for no params
		/// </summary>
		/*
		public Pheromosa() : this( "Pheromosa", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}