using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Wailord PokemonInstance Class
	#region Wailord
	public class Wailord : PokemonInstance
	{
		#region Wailord Constructors
		/// <summary>
		/// Wailord Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Wailord(string nickname, int level)
		: base(
				WailordSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wailord Constructor only waiting for a Level
		/// </summary>
		public Wailord(int level)
		: this( "Wailord", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wailord Constructor waiting for no params
		/// </summary>
		/*
		public Wailord() : this( "Wailord", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}