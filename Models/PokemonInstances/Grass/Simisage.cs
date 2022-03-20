using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Simisage PokemonInstance Class
	#region Simisage
	public class Simisage : PokemonInstance
	{
		#region Simisage Constructors
		/// <summary>
		/// Simisage Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Simisage(string nickname, int level)
		: base(
				SimisageSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simisage Constructor only waiting for a Level
		/// </summary>
		public Simisage(int level)
		: this( "Simisage", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simisage Constructor waiting for no params
		/// </summary>
		/*
		public Simisage() : this( "Simisage", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}