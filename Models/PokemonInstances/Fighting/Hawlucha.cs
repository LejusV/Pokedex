using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hawlucha PokemonInstance Class
	#region Hawlucha
	public class Hawlucha : PokemonInstance
	{
		#region Hawlucha Constructors
		/// <summary>
		/// Hawlucha Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Hawlucha(string nickname, int level)
		: base(
				HawluchaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hawlucha Constructor only waiting for a Level
		/// </summary>
		public Hawlucha(int level)
		: this( "Hawlucha", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hawlucha Constructor waiting for no params
		/// </summary>
		/*
		public Hawlucha() : this( "Hawlucha", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}