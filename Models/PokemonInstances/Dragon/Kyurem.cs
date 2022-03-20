using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kyurem PokemonInstance Class
	#region Kyurem
	public class Kyurem : PokemonInstance
	{
		#region Kyurem Constructors
		/// <summary>
		/// Kyurem Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Kyurem(string nickname, int level)
		: base(
				KyuremSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kyurem Constructor only waiting for a Level
		/// </summary>
		public Kyurem(int level)
		: this( "Kyurem", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kyurem Constructor waiting for no params
		/// </summary>
		/*
		public Kyurem() : this( "Kyurem", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}