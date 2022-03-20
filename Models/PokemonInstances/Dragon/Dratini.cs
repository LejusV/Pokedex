using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dratini PokemonInstance Class
	#region Dratini
	public class Dratini : PokemonInstance
	{
		#region Dratini Constructors
		/// <summary>
		/// Dratini Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dratini(string nickname, int level)
		: base(
				DratiniSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dratini Constructor only waiting for a Level
		/// </summary>
		public Dratini(int level)
		: this( "Dratini", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dratini Constructor waiting for no params
		/// </summary>
		/*
		public Dratini() : this( "Dratini", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}