using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Heatran PokemonInstance Class
	#region Heatran
	public class Heatran : PokemonInstance
	{
		#region Heatran Constructors
		/// <summary>
		/// Heatran Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Heatran(string nickname, int level)
		: base(
				HeatranSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heatran Constructor only waiting for a Level
		/// </summary>
		public Heatran(int level)
		: this( "Heatran", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heatran Constructor waiting for no params
		/// </summary>
		/*
		public Heatran() : this( "Heatran", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}