using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Raticate PokemonInstance Class
	#region Raticate
	public class Raticate : PokemonInstance
	{
		#region Raticate Constructors
		/// <summary>
		/// Raticate Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Raticate(string nickname, int level)
		: base(
				RaticateSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raticate Constructor only waiting for a Level
		/// </summary>
		public Raticate(int level)
		: this( "Raticate", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raticate Constructor waiting for no params
		/// </summary>
		/*
		public Raticate() : this( "Raticate", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}