using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Victreebel PokemonInstance Class
	#region Victreebel
	public class Victreebel : PokemonInstance
	{
		#region Victreebel Constructors
		/// <summary>
		/// Victreebel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Victreebel(string nickname, int level)
		: base(
				VictreebelSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Victreebel Constructor only waiting for a Level
		/// </summary>
		public Victreebel(int level)
		: this( "Victreebel", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Victreebel Constructor waiting for no params
		/// </summary>
		/*
		public Victreebel() : this( "Victreebel", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}