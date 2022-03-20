using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Foongus PokemonInstance Class
	#region Foongus
	public class Foongus : PokemonInstance
	{
		#region Foongus Constructors
		/// <summary>
		/// Foongus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Foongus(string nickname, int level)
		: base(
				FoongusSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Foongus Constructor only waiting for a Level
		/// </summary>
		public Foongus(int level)
		: this( "Foongus", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Foongus Constructor waiting for no params
		/// </summary>
		/*
		public Foongus() : this( "Foongus", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}