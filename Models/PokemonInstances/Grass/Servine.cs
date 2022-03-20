using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Servine PokemonInstance Class
	#region Servine
	public class Servine : PokemonInstance
	{
		#region Servine Constructors
		/// <summary>
		/// Servine Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Servine(string nickname, int level)
		: base(
				ServineSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Servine Constructor only waiting for a Level
		/// </summary>
		public Servine(int level)
		: this( "Servine", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Servine Constructor waiting for no params
		/// </summary>
		/*
		public Servine() : this( "Servine", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}