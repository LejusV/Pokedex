using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Nuzleaf PokemonInstance Class
	#region Nuzleaf
	public class Nuzleaf : PokemonInstance
	{
		#region Nuzleaf Constructors
		/// <summary>
		/// Nuzleaf Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Nuzleaf(string nickname, int level)
		: base(
				NuzleafSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nuzleaf Constructor only waiting for a Level
		/// </summary>
		public Nuzleaf(int level)
		: this( "Nuzleaf", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nuzleaf Constructor waiting for no params
		/// </summary>
		/*
		public Nuzleaf() : this( "Nuzleaf", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}