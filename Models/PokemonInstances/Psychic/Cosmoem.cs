using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cosmoem PokemonInstance Class
	#region Cosmoem
	public class Cosmoem : PokemonInstance
	{
		#region Cosmoem Constructors
		/// <summary>
		/// Cosmoem Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cosmoem(string nickname, int level)
		: base(
				CosmoemSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cosmoem Constructor only waiting for a Level
		/// </summary>
		public Cosmoem(int level)
		: this( "Cosmoem", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cosmoem Constructor waiting for no params
		/// </summary>
		/*
		public Cosmoem() : this( "Cosmoem", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}