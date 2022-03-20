using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Whismur PokemonInstance Class
	#region Whismur
	public class Whismur : PokemonInstance
	{
		#region Whismur Constructors
		/// <summary>
		/// Whismur Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Whismur(string nickname, int level)
		: base(
				WhismurSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whismur Constructor only waiting for a Level
		/// </summary>
		public Whismur(int level)
		: this( "Whismur", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whismur Constructor waiting for no params
		/// </summary>
		/*
		public Whismur() : this( "Whismur", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}