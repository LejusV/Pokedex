using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Abra PokemonInstance Class
	#region Abra
	public class Abra : PokemonInstance
	{
		#region Abra Constructors
		/// <summary>
		/// Abra Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Abra(string nickname, int level)
		: base(
				AbraSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Abra Constructor only waiting for a Level
		/// </summary>
		public Abra(int level)
		: this( "Abra", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Abra Constructor waiting for no params
		/// </summary>
		/*
		public Abra() : this( "Abra", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}