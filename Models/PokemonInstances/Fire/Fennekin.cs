using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Fennekin PokemonInstance Class
	#region Fennekin
	public class Fennekin : PokemonInstance
	{
		#region Fennekin Constructors
		/// <summary>
		/// Fennekin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Fennekin(string nickname, int level)
		: base(
				FennekinSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fennekin Constructor only waiting for a Level
		/// </summary>
		public Fennekin(int level)
		: this( "Fennekin", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fennekin Constructor waiting for no params
		/// </summary>
		/*
		public Fennekin() : this( "Fennekin", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}