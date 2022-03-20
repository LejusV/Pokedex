using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Orbeetle PokemonInstance Class
	#region Orbeetle
	public class Orbeetle : PokemonInstance
	{
		#region Orbeetle Constructors
		/// <summary>
		/// Orbeetle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Orbeetle(string nickname, int level)
		: base(
				OrbeetleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Orbeetle Constructor only waiting for a Level
		/// </summary>
		public Orbeetle(int level)
		: this( "Orbeetle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Orbeetle Constructor waiting for no params
		/// </summary>
		/*
		public Orbeetle() : this( "Orbeetle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}