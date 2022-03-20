using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hoppip PokemonInstance Class
	#region Hoppip
	public class Hoppip : PokemonInstance
	{
		#region Hoppip Constructors
		/// <summary>
		/// Hoppip Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Hoppip(string nickname, int level)
		: base(
				HoppipSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoppip Constructor only waiting for a Level
		/// </summary>
		public Hoppip(int level)
		: this( "Hoppip", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoppip Constructor waiting for no params
		/// </summary>
		/*
		public Hoppip() : this( "Hoppip", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}