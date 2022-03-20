using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Chingling PokemonInstance Class
	#region Chingling
	public class Chingling : PokemonInstance
	{
		#region Chingling Constructors
		/// <summary>
		/// Chingling Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Chingling(string nickname, int level)
		: base(
				ChinglingSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chingling Constructor only waiting for a Level
		/// </summary>
		public Chingling(int level)
		: this( "Chingling", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chingling Constructor waiting for no params
		/// </summary>
		/*
		public Chingling() : this( "Chingling", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}