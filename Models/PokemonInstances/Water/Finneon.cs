using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Finneon PokemonInstance Class
	#region Finneon
	public class Finneon : PokemonInstance
	{
		#region Finneon Constructors
		/// <summary>
		/// Finneon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Finneon(string nickname, int level)
		: base(
				FinneonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Finneon Constructor only waiting for a Level
		/// </summary>
		public Finneon(int level)
		: this( "Finneon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Finneon Constructor waiting for no params
		/// </summary>
		/*
		public Finneon() : this( "Finneon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}