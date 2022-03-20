using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ferrothorn PokemonInstance Class
	#region Ferrothorn
	public class Ferrothorn : PokemonInstance
	{
		#region Ferrothorn Constructors
		/// <summary>
		/// Ferrothorn Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ferrothorn(string nickname, int level)
		: base(
				FerrothornSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ferrothorn Constructor only waiting for a Level
		/// </summary>
		public Ferrothorn(int level)
		: this( "Ferrothorn", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ferrothorn Constructor waiting for no params
		/// </summary>
		/*
		public Ferrothorn() : this( "Ferrothorn", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}