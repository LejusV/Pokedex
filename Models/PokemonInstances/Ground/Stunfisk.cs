using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Stunfisk PokemonInstance Class
	#region Stunfisk
	public class Stunfisk : PokemonInstance
	{
		#region Stunfisk Constructors
		/// <summary>
		/// Stunfisk Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Stunfisk(string nickname, int level)
		: base(
				StunfiskSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stunfisk Constructor only waiting for a Level
		/// </summary>
		public Stunfisk(int level)
		: this( "Stunfisk", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stunfisk Constructor waiting for no params
		/// </summary>
		/*
		public Stunfisk() : this( "Stunfisk", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}