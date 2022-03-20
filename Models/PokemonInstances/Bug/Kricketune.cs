using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kricketune PokemonInstance Class
	#region Kricketune
	public class Kricketune : PokemonInstance
	{
		#region Kricketune Constructors
		/// <summary>
		/// Kricketune Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Kricketune(string nickname, int level)
		: base(
				KricketuneSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kricketune Constructor only waiting for a Level
		/// </summary>
		public Kricketune(int level)
		: this( "Kricketune", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kricketune Constructor waiting for no params
		/// </summary>
		/*
		public Kricketune() : this( "Kricketune", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}