using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kartana PokemonInstance Class
	#region Kartana
	public class Kartana : PokemonInstance
	{
		#region Kartana Constructors
		/// <summary>
		/// Kartana Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Kartana(string nickname, int level)
		: base(
				KartanaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kartana Constructor only waiting for a Level
		/// </summary>
		public Kartana(int level)
		: this( "Kartana", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kartana Constructor waiting for no params
		/// </summary>
		/*
		public Kartana() : this( "Kartana", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}