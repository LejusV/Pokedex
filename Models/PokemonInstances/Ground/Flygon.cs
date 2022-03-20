using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Flygon PokemonInstance Class
	#region Flygon
	public class Flygon : PokemonInstance
	{
		#region Flygon Constructors
		/// <summary>
		/// Flygon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Flygon(string nickname, int level)
		: base(
				FlygonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flygon Constructor only waiting for a Level
		/// </summary>
		public Flygon(int level)
		: this( "Flygon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flygon Constructor waiting for no params
		/// </summary>
		/*
		public Flygon() : this( "Flygon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}