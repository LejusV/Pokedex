using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Drakloak PokemonInstance Class
	#region Drakloak
	public class Drakloak : PokemonInstance
	{
		#region Drakloak Constructors
		/// <summary>
		/// Drakloak Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Drakloak(string nickname, int level)
		: base(
				DrakloakSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drakloak Constructor only waiting for a Level
		/// </summary>
		public Drakloak(int level)
		: this( "Drakloak", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drakloak Constructor waiting for no params
		/// </summary>
		/*
		public Drakloak() : this( "Drakloak", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}