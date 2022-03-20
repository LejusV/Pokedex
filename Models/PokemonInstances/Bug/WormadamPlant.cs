using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Wormadam-Plant PokemonInstance Class
	#region Wormadam-Plant
	public class WormadamPlant : PokemonInstance
	{
		#region Wormadam-Plant Constructors
		/// <summary>
		/// Wormadam-Plant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WormadamPlant(string nickname, int level)
		: base(
				WormadamPlantSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wormadam-Plant Constructor only waiting for a Level
		/// </summary>
		public WormadamPlant(int level)
		: this( "Wormadam-Plant", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wormadam-Plant Constructor waiting for no params
		/// </summary>
		/*
		public WormadamPlant() : this( "Wormadam-Plant", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}