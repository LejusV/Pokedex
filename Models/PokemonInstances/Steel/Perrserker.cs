using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Perrserker PokemonInstance Class
	#region Perrserker
	public class Perrserker : PokemonInstance
	{
		#region Perrserker Constructors
		/// <summary>
		/// Perrserker Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Perrserker(string nickname, int level)
		: base(
				PerrserkerSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Perrserker Constructor only waiting for a Level
		/// </summary>
		public Perrserker(int level)
		: this( "Perrserker", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Perrserker Constructor waiting for no params
		/// </summary>
		/*
		public Perrserker() : this( "Perrserker", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}