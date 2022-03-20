using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Breloom PokemonInstance Class
	#region Breloom
	public class Breloom : PokemonInstance
	{
		#region Breloom Constructors
		/// <summary>
		/// Breloom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Breloom(string nickname, int level)
		: base(
				BreloomSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Breloom Constructor only waiting for a Level
		/// </summary>
		public Breloom(int level)
		: this( "Breloom", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Breloom Constructor waiting for no params
		/// </summary>
		/*
		public Breloom() : this( "Breloom", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}