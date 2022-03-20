using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cleffa PokemonInstance Class
	#region Cleffa
	public class Cleffa : PokemonInstance
	{
		#region Cleffa Constructors
		/// <summary>
		/// Cleffa Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cleffa(string nickname, int level)
		: base(
				CleffaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cleffa Constructor only waiting for a Level
		/// </summary>
		public Cleffa(int level)
		: this( "Cleffa", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cleffa Constructor waiting for no params
		/// </summary>
		/*
		public Cleffa() : this( "Cleffa", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}