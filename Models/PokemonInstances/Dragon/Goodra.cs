using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Goodra PokemonInstance Class
	#region Goodra
	public class Goodra : PokemonInstance
	{
		#region Goodra Constructors
		/// <summary>
		/// Goodra Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Goodra(string nickname, int level)
		: base(
				GoodraSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goodra Constructor only waiting for a Level
		/// </summary>
		public Goodra(int level)
		: this( "Goodra", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goodra Constructor waiting for no params
		/// </summary>
		/*
		public Goodra() : this( "Goodra", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}