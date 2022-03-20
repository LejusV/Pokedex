using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ledyba PokemonInstance Class
	#region Ledyba
	public class Ledyba : PokemonInstance
	{
		#region Ledyba Constructors
		/// <summary>
		/// Ledyba Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ledyba(string nickname, int level)
		: base(
				LedybaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ledyba Constructor only waiting for a Level
		/// </summary>
		public Ledyba(int level)
		: this( "Ledyba", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ledyba Constructor waiting for no params
		/// </summary>
		/*
		public Ledyba() : this( "Ledyba", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}