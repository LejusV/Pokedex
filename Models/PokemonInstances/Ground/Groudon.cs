using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Groudon PokemonInstance Class
	#region Groudon
	public class Groudon : PokemonInstance
	{
		#region Groudon Constructors
		/// <summary>
		/// Groudon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Groudon(string nickname, int level)
		: base(
				GroudonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Groudon Constructor only waiting for a Level
		/// </summary>
		public Groudon(int level)
		: this( "Groudon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Groudon Constructor waiting for no params
		/// </summary>
		/*
		public Groudon() : this( "Groudon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}