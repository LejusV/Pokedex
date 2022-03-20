using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Panpour PokemonInstance Class
	#region Panpour
	public class Panpour : PokemonInstance
	{
		#region Panpour Constructors
		/// <summary>
		/// Panpour Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Panpour(string nickname, int level)
		: base(
				PanpourSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Panpour Constructor only waiting for a Level
		/// </summary>
		public Panpour(int level)
		: this( "Panpour", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Panpour Constructor waiting for no params
		/// </summary>
		/*
		public Panpour() : this( "Panpour", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}