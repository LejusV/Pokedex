using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Centiskorch PokemonInstance Class
	#region Centiskorch
	public class Centiskorch : PokemonInstance
	{
		#region Centiskorch Constructors
		/// <summary>
		/// Centiskorch Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Centiskorch(string nickname, int level)
		: base(
				CentiskorchSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Centiskorch Constructor only waiting for a Level
		/// </summary>
		public Centiskorch(int level)
		: this( "Centiskorch", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Centiskorch Constructor waiting for no params
		/// </summary>
		/*
		public Centiskorch() : this( "Centiskorch", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}