using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Metapod PokemonInstance Class
	#region Metapod
	public class Metapod : PokemonInstance
	{
		#region Metapod Constructors
		/// <summary>
		/// Metapod Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Metapod(string nickname, int level)
		: base(
				MetapodSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metapod Constructor only waiting for a Level
		/// </summary>
		public Metapod(int level)
		: this( "Metapod", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metapod Constructor waiting for no params
		/// </summary>
		/*
		public Metapod() : this( "Metapod", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}