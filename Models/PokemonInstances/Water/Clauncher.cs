using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Clauncher PokemonInstance Class
	#region Clauncher
	public class Clauncher : PokemonInstance
	{
		#region Clauncher Constructors
		/// <summary>
		/// Clauncher Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Clauncher(string nickname, int level)
		: base(
				ClauncherSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clauncher Constructor only waiting for a Level
		/// </summary>
		public Clauncher(int level)
		: this( "Clauncher", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clauncher Constructor waiting for no params
		/// </summary>
		/*
		public Clauncher() : this( "Clauncher", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}