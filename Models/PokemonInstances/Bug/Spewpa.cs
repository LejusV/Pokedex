using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Spewpa PokemonInstance Class
	#region Spewpa
	public class Spewpa : PokemonInstance
	{
		#region Spewpa Constructors
		/// <summary>
		/// Spewpa Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Spewpa(string nickname, int level)
		: base(
				SpewpaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spewpa Constructor only waiting for a Level
		/// </summary>
		public Spewpa(int level)
		: this( "Spewpa", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spewpa Constructor waiting for no params
		/// </summary>
		/*
		public Spewpa() : this( "Spewpa", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}