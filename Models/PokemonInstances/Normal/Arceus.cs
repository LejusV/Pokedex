using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Arceus PokemonInstance Class
	#region Arceus
	public class Arceus : PokemonInstance
	{
		#region Arceus Constructors
		/// <summary>
		/// Arceus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Arceus(string nickname, int level)
		: base(
				ArceusSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arceus Constructor only waiting for a Level
		/// </summary>
		public Arceus(int level)
		: this( "Arceus", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arceus Constructor waiting for no params
		/// </summary>
		/*
		public Arceus() : this( "Arceus", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}