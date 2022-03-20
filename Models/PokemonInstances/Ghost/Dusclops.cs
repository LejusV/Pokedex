using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dusclops PokemonInstance Class
	#region Dusclops
	public class Dusclops : PokemonInstance
	{
		#region Dusclops Constructors
		/// <summary>
		/// Dusclops Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dusclops(string nickname, int level)
		: base(
				DusclopsSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dusclops Constructor only waiting for a Level
		/// </summary>
		public Dusclops(int level)
		: this( "Dusclops", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dusclops Constructor waiting for no params
		/// </summary>
		/*
		public Dusclops() : this( "Dusclops", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}