using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Heatmor PokemonInstance Class
	#region Heatmor
	public class Heatmor : PokemonInstance
	{
		#region Heatmor Constructors
		/// <summary>
		/// Heatmor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Heatmor(string nickname, int level)
		: base(
				HeatmorSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heatmor Constructor only waiting for a Level
		/// </summary>
		public Heatmor(int level)
		: this( "Heatmor", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heatmor Constructor waiting for no params
		/// </summary>
		/*
		public Heatmor() : this( "Heatmor", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}