using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Zekrom PokemonInstance Class
	#region Zekrom
	public class Zekrom : PokemonInstance
	{
		#region Zekrom Constructors
		/// <summary>
		/// Zekrom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Zekrom(string nickname, int level)
		: base(
				ZekromSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zekrom Constructor only waiting for a Level
		/// </summary>
		public Zekrom(int level)
		: this( "Zekrom", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zekrom Constructor waiting for no params
		/// </summary>
		/*
		public Zekrom() : this( "Zekrom", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}