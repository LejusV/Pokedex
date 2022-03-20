using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Chesnaught PokemonInstance Class
	#region Chesnaught
	public class Chesnaught : PokemonInstance
	{
		#region Chesnaught Constructors
		/// <summary>
		/// Chesnaught Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Chesnaught(string nickname, int level)
		: base(
				ChesnaughtSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chesnaught Constructor only waiting for a Level
		/// </summary>
		public Chesnaught(int level)
		: this( "Chesnaught", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chesnaught Constructor waiting for no params
		/// </summary>
		/*
		public Chesnaught() : this( "Chesnaught", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}