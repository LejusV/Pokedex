using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Golurk PokemonInstance Class
	#region Golurk
	public class Golurk : PokemonInstance
	{
		#region Golurk Constructors
		/// <summary>
		/// Golurk Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Golurk(string nickname, int level)
		: base(
				GolurkSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golurk Constructor only waiting for a Level
		/// </summary>
		public Golurk(int level)
		: this( "Golurk", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golurk Constructor waiting for no params
		/// </summary>
		/*
		public Golurk() : this( "Golurk", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}