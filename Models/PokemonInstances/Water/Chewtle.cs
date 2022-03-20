using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Chewtle PokemonInstance Class
	#region Chewtle
	public class Chewtle : PokemonInstance
	{
		#region Chewtle Constructors
		/// <summary>
		/// Chewtle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Chewtle(string nickname, int level)
		: base(
				ChewtleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chewtle Constructor only waiting for a Level
		/// </summary>
		public Chewtle(int level)
		: this( "Chewtle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chewtle Constructor waiting for no params
		/// </summary>
		/*
		public Chewtle() : this( "Chewtle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}