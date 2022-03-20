using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cutiefly PokemonInstance Class
	#region Cutiefly
	public class Cutiefly : PokemonInstance
	{
		#region Cutiefly Constructors
		/// <summary>
		/// Cutiefly Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cutiefly(string nickname, int level)
		: base(
				CutieflySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cutiefly Constructor only waiting for a Level
		/// </summary>
		public Cutiefly(int level)
		: this( "Cutiefly", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cutiefly Constructor waiting for no params
		/// </summary>
		/*
		public Cutiefly() : this( "Cutiefly", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}