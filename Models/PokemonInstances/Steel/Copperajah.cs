using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Copperajah PokemonInstance Class
	#region Copperajah
	public class Copperajah : PokemonInstance
	{
		#region Copperajah Constructors
		/// <summary>
		/// Copperajah Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Copperajah(string nickname, int level)
		: base(
				CopperajahSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Copperajah Constructor only waiting for a Level
		/// </summary>
		public Copperajah(int level)
		: this( "Copperajah", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Copperajah Constructor waiting for no params
		/// </summary>
		/*
		public Copperajah() : this( "Copperajah", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}