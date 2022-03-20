using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Claydol PokemonInstance Class
	#region Claydol
	public class Claydol : PokemonInstance
	{
		#region Claydol Constructors
		/// <summary>
		/// Claydol Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Claydol(string nickname, int level)
		: base(
				ClaydolSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Claydol Constructor only waiting for a Level
		/// </summary>
		public Claydol(int level)
		: this( "Claydol", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Claydol Constructor waiting for no params
		/// </summary>
		/*
		public Claydol() : this( "Claydol", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}