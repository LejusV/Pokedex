using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Vanilluxe PokemonInstance Class
	#region Vanilluxe
	public class Vanilluxe : PokemonInstance
	{
		#region Vanilluxe Constructors
		/// <summary>
		/// Vanilluxe Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Vanilluxe(string nickname, int level)
		: base(
				VanilluxeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanilluxe Constructor only waiting for a Level
		/// </summary>
		public Vanilluxe(int level)
		: this( "Vanilluxe", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanilluxe Constructor waiting for no params
		/// </summary>
		/*
		public Vanilluxe() : this( "Vanilluxe", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}