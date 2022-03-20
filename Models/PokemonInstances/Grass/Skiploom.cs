using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Skiploom PokemonInstance Class
	#region Skiploom
	public class Skiploom : PokemonInstance
	{
		#region Skiploom Constructors
		/// <summary>
		/// Skiploom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Skiploom(string nickname, int level)
		: base(
				SkiploomSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skiploom Constructor only waiting for a Level
		/// </summary>
		public Skiploom(int level)
		: this( "Skiploom", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skiploom Constructor waiting for no params
		/// </summary>
		/*
		public Skiploom() : this( "Skiploom", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}