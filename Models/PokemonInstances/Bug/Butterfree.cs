using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Butterfree PokemonInstance Class
	#region Butterfree
	public class Butterfree : PokemonInstance
	{
		#region Butterfree Constructors
		/// <summary>
		/// Butterfree Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Butterfree(string nickname, int level)
		: base(
				ButterfreeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Butterfree Constructor only waiting for a Level
		/// </summary>
		public Butterfree(int level)
		: this( "Butterfree", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Butterfree Constructor waiting for no params
		/// </summary>
		/*
		public Butterfree() : this( "Butterfree", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}