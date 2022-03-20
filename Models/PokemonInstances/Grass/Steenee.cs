using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Steenee PokemonInstance Class
	#region Steenee
	public class Steenee : PokemonInstance
	{
		#region Steenee Constructors
		/// <summary>
		/// Steenee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Steenee(string nickname, int level)
		: base(
				SteeneeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Steenee Constructor only waiting for a Level
		/// </summary>
		public Steenee(int level)
		: this( "Steenee", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Steenee Constructor waiting for no params
		/// </summary>
		/*
		public Steenee() : this( "Steenee", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}