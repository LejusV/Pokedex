using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pidove PokemonInstance Class
	#region Pidove
	public class Pidove : PokemonInstance
	{
		#region Pidove Constructors
		/// <summary>
		/// Pidove Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pidove(string nickname, int level)
		: base(
				PidoveSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidove Constructor only waiting for a Level
		/// </summary>
		public Pidove(int level)
		: this( "Pidove", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidove Constructor waiting for no params
		/// </summary>
		/*
		public Pidove() : this( "Pidove", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}