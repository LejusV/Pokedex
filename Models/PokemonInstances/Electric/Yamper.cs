using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Yamper PokemonInstance Class
	#region Yamper
	public class Yamper : PokemonInstance
	{
		#region Yamper Constructors
		/// <summary>
		/// Yamper Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Yamper(string nickname, int level)
		: base(
				YamperSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yamper Constructor only waiting for a Level
		/// </summary>
		public Yamper(int level)
		: this( "Yamper", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yamper Constructor waiting for no params
		/// </summary>
		/*
		public Yamper() : this( "Yamper", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}