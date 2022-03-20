using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Luxray PokemonInstance Class
	#region Luxray
	public class Luxray : PokemonInstance
	{
		#region Luxray Constructors
		/// <summary>
		/// Luxray Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Luxray(string nickname, int level)
		: base(
				LuxraySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luxray Constructor only waiting for a Level
		/// </summary>
		public Luxray(int level)
		: this( "Luxray", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luxray Constructor waiting for no params
		/// </summary>
		/*
		public Luxray() : this( "Luxray", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}