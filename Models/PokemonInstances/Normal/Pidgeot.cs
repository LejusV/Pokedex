using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pidgeot PokemonInstance Class
	#region Pidgeot
	public class Pidgeot : PokemonInstance
	{
		#region Pidgeot Constructors
		/// <summary>
		/// Pidgeot Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pidgeot(string nickname, int level)
		: base(
				PidgeotSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgeot Constructor only waiting for a Level
		/// </summary>
		public Pidgeot(int level)
		: this( "Pidgeot", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgeot Constructor waiting for no params
		/// </summary>
		/*
		public Pidgeot() : this( "Pidgeot", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}