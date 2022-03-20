using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sneasel PokemonInstance Class
	#region Sneasel
	public class Sneasel : PokemonInstance
	{
		#region Sneasel Constructors
		/// <summary>
		/// Sneasel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sneasel(string nickname, int level)
		: base(
				SneaselSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sneasel Constructor only waiting for a Level
		/// </summary>
		public Sneasel(int level)
		: this( "Sneasel", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sneasel Constructor waiting for no params
		/// </summary>
		/*
		public Sneasel() : this( "Sneasel", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}