using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Accelgor PokemonInstance Class
	#region Accelgor
	public class Accelgor : PokemonInstance
	{
		#region Accelgor Constructors
		/// <summary>
		/// Accelgor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Accelgor(string nickname, int level)
		: base(
				AccelgorSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Accelgor Constructor only waiting for a Level
		/// </summary>
		public Accelgor(int level)
		: this( "Accelgor", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Accelgor Constructor waiting for no params
		/// </summary>
		/*
		public Accelgor() : this( "Accelgor", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}