using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Clobbopus PokemonInstance Class
	#region Clobbopus
	public class Clobbopus : PokemonInstance
	{
		#region Clobbopus Constructors
		/// <summary>
		/// Clobbopus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Clobbopus(string nickname, int level)
		: base(
				ClobbopusSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clobbopus Constructor only waiting for a Level
		/// </summary>
		public Clobbopus(int level)
		: this( "Clobbopus", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clobbopus Constructor waiting for no params
		/// </summary>
		/*
		public Clobbopus() : this( "Clobbopus", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}