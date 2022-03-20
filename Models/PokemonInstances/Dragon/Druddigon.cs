using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Druddigon PokemonInstance Class
	#region Druddigon
	public class Druddigon : PokemonInstance
	{
		#region Druddigon Constructors
		/// <summary>
		/// Druddigon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Druddigon(string nickname, int level)
		: base(
				DruddigonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Druddigon Constructor only waiting for a Level
		/// </summary>
		public Druddigon(int level)
		: this( "Druddigon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Druddigon Constructor waiting for no params
		/// </summary>
		/*
		public Druddigon() : this( "Druddigon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}