using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Wartortle PokemonInstance Class
	#region Wartortle
	public class Wartortle : PokemonInstance
	{
		#region Wartortle Constructors
		/// <summary>
		/// Wartortle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Wartortle(string nickname, int level)
		: base(
				WartortleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wartortle Constructor only waiting for a Level
		/// </summary>
		public Wartortle(int level)
		: this( "Wartortle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wartortle Constructor waiting for no params
		/// </summary>
		/*
		public Wartortle() : this( "Wartortle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}