using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Klefki PokemonInstance Class
	#region Klefki
	public class Klefki : PokemonInstance
	{
		#region Klefki Constructors
		/// <summary>
		/// Klefki Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Klefki(string nickname, int level)
		: base(
				KlefkiSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klefki Constructor only waiting for a Level
		/// </summary>
		public Klefki(int level)
		: this( "Klefki", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klefki Constructor waiting for no params
		/// </summary>
		/*
		public Klefki() : this( "Klefki", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}