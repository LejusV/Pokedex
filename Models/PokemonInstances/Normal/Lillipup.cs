using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lillipup PokemonInstance Class
	#region Lillipup
	public class Lillipup : PokemonInstance
	{
		#region Lillipup Constructors
		/// <summary>
		/// Lillipup Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lillipup(string nickname, int level)
		: base(
				LillipupSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lillipup Constructor only waiting for a Level
		/// </summary>
		public Lillipup(int level)
		: this( "Lillipup", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lillipup Constructor waiting for no params
		/// </summary>
		/*
		public Lillipup() : this( "Lillipup", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}