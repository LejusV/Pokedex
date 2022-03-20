using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Rillaboom PokemonInstance Class
	#region Rillaboom
	public class Rillaboom : PokemonInstance
	{
		#region Rillaboom Constructors
		/// <summary>
		/// Rillaboom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Rillaboom(string nickname, int level)
		: base(
				RillaboomSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rillaboom Constructor only waiting for a Level
		/// </summary>
		public Rillaboom(int level)
		: this( "Rillaboom", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rillaboom Constructor waiting for no params
		/// </summary>
		/*
		public Rillaboom() : this( "Rillaboom", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}