using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Totodile PokemonInstance Class
	#region Totodile
	public class Totodile : PokemonInstance
	{
		#region Totodile Constructors
		/// <summary>
		/// Totodile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Totodile(string nickname, int level)
		: base(
				TotodileSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Totodile Constructor only waiting for a Level
		/// </summary>
		public Totodile(int level)
		: this( "Totodile", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Totodile Constructor waiting for no params
		/// </summary>
		/*
		public Totodile() : this( "Totodile", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}