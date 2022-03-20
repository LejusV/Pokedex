using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Larvesta PokemonInstance Class
	#region Larvesta
	public class Larvesta : PokemonInstance
	{
		#region Larvesta Constructors
		/// <summary>
		/// Larvesta Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Larvesta(string nickname, int level)
		: base(
				LarvestaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Larvesta Constructor only waiting for a Level
		/// </summary>
		public Larvesta(int level)
		: this( "Larvesta", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Larvesta Constructor waiting for no params
		/// </summary>
		/*
		public Larvesta() : this( "Larvesta", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}