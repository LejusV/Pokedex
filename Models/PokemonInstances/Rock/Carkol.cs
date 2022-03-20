using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Carkol PokemonInstance Class
	#region Carkol
	public class Carkol : PokemonInstance
	{
		#region Carkol Constructors
		/// <summary>
		/// Carkol Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Carkol(string nickname, int level)
		: base(
				CarkolSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carkol Constructor only waiting for a Level
		/// </summary>
		public Carkol(int level)
		: this( "Carkol", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carkol Constructor waiting for no params
		/// </summary>
		/*
		public Carkol() : this( "Carkol", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}