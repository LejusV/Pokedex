using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Eelektross PokemonInstance Class
	#region Eelektross
	public class Eelektross : PokemonInstance
	{
		#region Eelektross Constructors
		/// <summary>
		/// Eelektross Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Eelektross(string nickname, int level)
		: base(
				EelektrossSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eelektross Constructor only waiting for a Level
		/// </summary>
		public Eelektross(int level)
		: this( "Eelektross", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eelektross Constructor waiting for no params
		/// </summary>
		/*
		public Eelektross() : this( "Eelektross", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}