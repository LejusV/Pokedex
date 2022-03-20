using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Aurorus PokemonInstance Class
	#region Aurorus
	public class Aurorus : PokemonInstance
	{
		#region Aurorus Constructors
		/// <summary>
		/// Aurorus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Aurorus(string nickname, int level)
		: base(
				AurorusSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aurorus Constructor only waiting for a Level
		/// </summary>
		public Aurorus(int level)
		: this( "Aurorus", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aurorus Constructor waiting for no params
		/// </summary>
		/*
		public Aurorus() : this( "Aurorus", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}