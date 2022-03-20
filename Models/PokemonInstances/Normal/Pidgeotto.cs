using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pidgeotto PokemonInstance Class
	#region Pidgeotto
	public class Pidgeotto : PokemonInstance
	{
		#region Pidgeotto Constructors
		/// <summary>
		/// Pidgeotto Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pidgeotto(string nickname, int level)
		: base(
				PidgeottoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgeotto Constructor only waiting for a Level
		/// </summary>
		public Pidgeotto(int level)
		: this( "Pidgeotto", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgeotto Constructor waiting for no params
		/// </summary>
		/*
		public Pidgeotto() : this( "Pidgeotto", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}