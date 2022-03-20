using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Komala PokemonInstance Class
	#region Komala
	public class Komala : PokemonInstance
	{
		#region Komala Constructors
		/// <summary>
		/// Komala Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Komala(string nickname, int level)
		: base(
				KomalaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Komala Constructor only waiting for a Level
		/// </summary>
		public Komala(int level)
		: this( "Komala", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Komala Constructor waiting for no params
		/// </summary>
		/*
		public Komala() : this( "Komala", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}