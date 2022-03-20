using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tsareena PokemonInstance Class
	#region Tsareena
	public class Tsareena : PokemonInstance
	{
		#region Tsareena Constructors
		/// <summary>
		/// Tsareena Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tsareena(string nickname, int level)
		: base(
				TsareenaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tsareena Constructor only waiting for a Level
		/// </summary>
		public Tsareena(int level)
		: this( "Tsareena", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tsareena Constructor waiting for no params
		/// </summary>
		/*
		public Tsareena() : this( "Tsareena", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}