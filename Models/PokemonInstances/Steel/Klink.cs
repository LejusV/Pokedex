using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Klink PokemonInstance Class
	#region Klink
	public class Klink : PokemonInstance
	{
		#region Klink Constructors
		/// <summary>
		/// Klink Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Klink(string nickname, int level)
		: base(
				KlinkSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klink Constructor only waiting for a Level
		/// </summary>
		public Klink(int level)
		: this( "Klink", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klink Constructor waiting for no params
		/// </summary>
		/*
		public Klink() : this( "Klink", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}