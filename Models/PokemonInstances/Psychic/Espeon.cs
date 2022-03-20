using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Espeon PokemonInstance Class
	#region Espeon
	public class Espeon : PokemonInstance
	{
		#region Espeon Constructors
		/// <summary>
		/// Espeon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Espeon(string nickname, int level)
		: base(
				EspeonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Espeon Constructor only waiting for a Level
		/// </summary>
		public Espeon(int level)
		: this( "Espeon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Espeon Constructor waiting for no params
		/// </summary>
		/*
		public Espeon() : this( "Espeon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}