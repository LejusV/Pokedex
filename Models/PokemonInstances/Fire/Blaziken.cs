using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Blaziken PokemonInstance Class
	#region Blaziken
	public class Blaziken : PokemonInstance
	{
		#region Blaziken Constructors
		/// <summary>
		/// Blaziken Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Blaziken(string nickname, int level)
		: base(
				BlazikenSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blaziken Constructor only waiting for a Level
		/// </summary>
		public Blaziken(int level)
		: this( "Blaziken", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blaziken Constructor waiting for no params
		/// </summary>
		/*
		public Blaziken() : this( "Blaziken", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}