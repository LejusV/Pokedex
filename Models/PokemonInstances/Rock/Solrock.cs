using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Solrock PokemonInstance Class
	#region Solrock
	public class Solrock : PokemonInstance
	{
		#region Solrock Constructors
		/// <summary>
		/// Solrock Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Solrock(string nickname, int level)
		: base(
				SolrockSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solrock Constructor only waiting for a Level
		/// </summary>
		public Solrock(int level)
		: this( "Solrock", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solrock Constructor waiting for no params
		/// </summary>
		/*
		public Solrock() : this( "Solrock", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}