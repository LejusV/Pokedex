using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Absol PokemonInstance Class
	#region Absol
	public class Absol : PokemonInstance
	{
		#region Absol Constructors
		/// <summary>
		/// Absol Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Absol(string nickname, int level)
		: base(
				AbsolSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Absol Constructor only waiting for a Level
		/// </summary>
		public Absol(int level)
		: this( "Absol", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Absol Constructor waiting for no params
		/// </summary>
		/*
		public Absol() : this( "Absol", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}