using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Happiny PokemonInstance Class
	#region Happiny
	public class Happiny : PokemonInstance
	{
		#region Happiny Constructors
		/// <summary>
		/// Happiny Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Happiny(string nickname, int level)
		: base(
				HappinySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Happiny Constructor only waiting for a Level
		/// </summary>
		public Happiny(int level)
		: this( "Happiny", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Happiny Constructor waiting for no params
		/// </summary>
		/*
		public Happiny() : this( "Happiny", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}