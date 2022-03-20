using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Togekiss PokemonInstance Class
	#region Togekiss
	public class Togekiss : PokemonInstance
	{
		#region Togekiss Constructors
		/// <summary>
		/// Togekiss Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Togekiss(string nickname, int level)
		: base(
				TogekissSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togekiss Constructor only waiting for a Level
		/// </summary>
		public Togekiss(int level)
		: this( "Togekiss", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togekiss Constructor waiting for no params
		/// </summary>
		/*
		public Togekiss() : this( "Togekiss", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}