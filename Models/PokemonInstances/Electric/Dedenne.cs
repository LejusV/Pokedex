using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dedenne PokemonInstance Class
	#region Dedenne
	public class Dedenne : PokemonInstance
	{
		#region Dedenne Constructors
		/// <summary>
		/// Dedenne Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dedenne(string nickname, int level)
		: base(
				DedenneSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dedenne Constructor only waiting for a Level
		/// </summary>
		public Dedenne(int level)
		: this( "Dedenne", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dedenne Constructor waiting for no params
		/// </summary>
		/*
		public Dedenne() : this( "Dedenne", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}