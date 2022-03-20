using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dialga PokemonInstance Class
	#region Dialga
	public class Dialga : PokemonInstance
	{
		#region Dialga Constructors
		/// <summary>
		/// Dialga Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dialga(string nickname, int level)
		: base(
				DialgaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dialga Constructor only waiting for a Level
		/// </summary>
		public Dialga(int level)
		: this( "Dialga", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dialga Constructor waiting for no params
		/// </summary>
		/*
		public Dialga() : this( "Dialga", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}