using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Blissey PokemonInstance Class
	#region Blissey
	public class Blissey : PokemonInstance
	{
		#region Blissey Constructors
		/// <summary>
		/// Blissey Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Blissey(string nickname, int level)
		: base(
				BlisseySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blissey Constructor only waiting for a Level
		/// </summary>
		public Blissey(int level)
		: this( "Blissey", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blissey Constructor waiting for no params
		/// </summary>
		/*
		public Blissey() : this( "Blissey", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}