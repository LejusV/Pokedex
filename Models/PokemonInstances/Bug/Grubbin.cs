using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Grubbin PokemonInstance Class
	#region Grubbin
	public class Grubbin : PokemonInstance
	{
		#region Grubbin Constructors
		/// <summary>
		/// Grubbin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Grubbin(string nickname, int level)
		: base(
				GrubbinSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grubbin Constructor only waiting for a Level
		/// </summary>
		public Grubbin(int level)
		: this( "Grubbin", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grubbin Constructor waiting for no params
		/// </summary>
		/*
		public Grubbin() : this( "Grubbin", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}