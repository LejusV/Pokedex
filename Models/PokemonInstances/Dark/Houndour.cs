using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Houndour PokemonInstance Class
	#region Houndour
	public class Houndour : PokemonInstance
	{
		#region Houndour Constructors
		/// <summary>
		/// Houndour Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Houndour(string nickname, int level)
		: base(
				HoundourSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Houndour Constructor only waiting for a Level
		/// </summary>
		public Houndour(int level)
		: this( "Houndour", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Houndour Constructor waiting for no params
		/// </summary>
		/*
		public Houndour() : this( "Houndour", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}