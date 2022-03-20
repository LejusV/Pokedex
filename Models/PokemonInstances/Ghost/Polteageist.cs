using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Polteageist PokemonInstance Class
	#region Polteageist
	public class Polteageist : PokemonInstance
	{
		#region Polteageist Constructors
		/// <summary>
		/// Polteageist Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Polteageist(string nickname, int level)
		: base(
				PolteageistSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Polteageist Constructor only waiting for a Level
		/// </summary>
		public Polteageist(int level)
		: this( "Polteageist", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Polteageist Constructor waiting for no params
		/// </summary>
		/*
		public Polteageist() : this( "Polteageist", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}