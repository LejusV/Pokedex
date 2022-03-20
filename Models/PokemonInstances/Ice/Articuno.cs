using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Articuno PokemonInstance Class
	#region Articuno
	public class Articuno : PokemonInstance
	{
		#region Articuno Constructors
		/// <summary>
		/// Articuno Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Articuno(string nickname, int level)
		: base(
				ArticunoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Articuno Constructor only waiting for a Level
		/// </summary>
		public Articuno(int level)
		: this( "Articuno", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Articuno Constructor waiting for no params
		/// </summary>
		/*
		public Articuno() : this( "Articuno", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}