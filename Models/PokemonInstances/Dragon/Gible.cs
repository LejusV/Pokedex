using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gible PokemonInstance Class
	#region Gible
	public class Gible : PokemonInstance
	{
		#region Gible Constructors
		/// <summary>
		/// Gible Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gible(string nickname, int level)
		: base(
				GibleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gible Constructor only waiting for a Level
		/// </summary>
		public Gible(int level)
		: this( "Gible", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gible Constructor waiting for no params
		/// </summary>
		/*
		public Gible() : this( "Gible", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}