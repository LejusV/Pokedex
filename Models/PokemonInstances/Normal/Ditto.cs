using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ditto PokemonInstance Class
	#region Ditto
	public class Ditto : PokemonInstance
	{
		#region Ditto Constructors
		/// <summary>
		/// Ditto Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ditto(string nickname, int level)
		: base(
				DittoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ditto Constructor only waiting for a Level
		/// </summary>
		public Ditto(int level)
		: this( "Ditto", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ditto Constructor waiting for no params
		/// </summary>
		/*
		public Ditto() : this( "Ditto", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}