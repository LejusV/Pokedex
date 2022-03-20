using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Huntail PokemonInstance Class
	#region Huntail
	public class Huntail : PokemonInstance
	{
		#region Huntail Constructors
		/// <summary>
		/// Huntail Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Huntail(string nickname, int level)
		: base(
				HuntailSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Huntail Constructor only waiting for a Level
		/// </summary>
		public Huntail(int level)
		: this( "Huntail", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Huntail Constructor waiting for no params
		/// </summary>
		/*
		public Huntail() : this( "Huntail", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}