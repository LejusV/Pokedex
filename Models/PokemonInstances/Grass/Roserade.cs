using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Roserade PokemonInstance Class
	#region Roserade
	public class Roserade : PokemonInstance
	{
		#region Roserade Constructors
		/// <summary>
		/// Roserade Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Roserade(string nickname, int level)
		: base(
				RoseradeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roserade Constructor only waiting for a Level
		/// </summary>
		public Roserade(int level)
		: this( "Roserade", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roserade Constructor waiting for no params
		/// </summary>
		/*
		public Roserade() : this( "Roserade", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}