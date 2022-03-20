using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ivysaur PokemonInstance Class
	#region Ivysaur
	public class Ivysaur : PokemonInstance
	{
		#region Ivysaur Constructors
		/// <summary>
		/// Ivysaur Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ivysaur(string nickname, int level)
		: base(
				IvysaurSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ivysaur Constructor only waiting for a Level
		/// </summary>
		public Ivysaur(int level)
		: this( "Ivysaur", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ivysaur Constructor waiting for no params
		/// </summary>
		/*
		public Ivysaur() : this( "Ivysaur", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}