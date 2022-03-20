using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hypno PokemonInstance Class
	#region Hypno
	public class Hypno : PokemonInstance
	{
		#region Hypno Constructors
		/// <summary>
		/// Hypno Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Hypno(string nickname, int level)
		: base(
				HypnoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hypno Constructor only waiting for a Level
		/// </summary>
		public Hypno(int level)
		: this( "Hypno", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hypno Constructor waiting for no params
		/// </summary>
		/*
		public Hypno() : this( "Hypno", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}