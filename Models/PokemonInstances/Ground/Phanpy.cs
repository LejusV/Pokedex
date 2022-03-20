using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Phanpy PokemonInstance Class
	#region Phanpy
	public class Phanpy : PokemonInstance
	{
		#region Phanpy Constructors
		/// <summary>
		/// Phanpy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Phanpy(string nickname, int level)
		: base(
				PhanpySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phanpy Constructor only waiting for a Level
		/// </summary>
		public Phanpy(int level)
		: this( "Phanpy", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phanpy Constructor waiting for no params
		/// </summary>
		/*
		public Phanpy() : this( "Phanpy", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}