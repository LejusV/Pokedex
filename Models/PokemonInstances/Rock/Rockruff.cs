using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Rockruff PokemonInstance Class
	#region Rockruff
	public class Rockruff : PokemonInstance
	{
		#region Rockruff Constructors
		/// <summary>
		/// Rockruff Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Rockruff(string nickname, int level)
		: base(
				RockruffSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rockruff Constructor only waiting for a Level
		/// </summary>
		public Rockruff(int level)
		: this( "Rockruff", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rockruff Constructor waiting for no params
		/// </summary>
		/*
		public Rockruff() : this( "Rockruff", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}