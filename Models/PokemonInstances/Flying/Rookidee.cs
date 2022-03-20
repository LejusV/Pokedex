using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Rookidee PokemonInstance Class
	#region Rookidee
	public class Rookidee : PokemonInstance
	{
		#region Rookidee Constructors
		/// <summary>
		/// Rookidee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Rookidee(string nickname, int level)
		: base(
				RookideeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rookidee Constructor only waiting for a Level
		/// </summary>
		public Rookidee(int level)
		: this( "Rookidee", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rookidee Constructor waiting for no params
		/// </summary>
		/*
		public Rookidee() : this( "Rookidee", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}