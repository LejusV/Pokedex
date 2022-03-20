using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Magcargo PokemonInstance Class
	#region Magcargo
	public class Magcargo : PokemonInstance
	{
		#region Magcargo Constructors
		/// <summary>
		/// Magcargo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Magcargo(string nickname, int level)
		: base(
				MagcargoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magcargo Constructor only waiting for a Level
		/// </summary>
		public Magcargo(int level)
		: this( "Magcargo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magcargo Constructor waiting for no params
		/// </summary>
		/*
		public Magcargo() : this( "Magcargo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}