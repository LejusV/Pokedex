using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bulbasaur PokemonInstance Class
	#region Bulbasaur
	public class Bulbasaur : PokemonInstance
	{
		#region Bulbasaur Constructors
		/// <summary>
		/// Bulbasaur Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bulbasaur(string nickname, int level)
		: base(
				BulbasaurSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bulbasaur Constructor only waiting for a Level
		/// </summary>
		public Bulbasaur(int level)
		: this( "Bulbasaur", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bulbasaur Constructor waiting for no params
		/// </summary>
		/*
		public Bulbasaur() : this( "Bulbasaur", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}