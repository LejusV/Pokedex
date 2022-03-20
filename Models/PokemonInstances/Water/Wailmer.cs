using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Wailmer PokemonInstance Class
	#region Wailmer
	public class Wailmer : PokemonInstance
	{
		#region Wailmer Constructors
		/// <summary>
		/// Wailmer Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Wailmer(string nickname, int level)
		: base(
				WailmerSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wailmer Constructor only waiting for a Level
		/// </summary>
		public Wailmer(int level)
		: this( "Wailmer", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wailmer Constructor waiting for no params
		/// </summary>
		/*
		public Wailmer() : this( "Wailmer", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}