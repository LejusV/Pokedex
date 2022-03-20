using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cinccino PokemonInstance Class
	#region Cinccino
	public class Cinccino : PokemonInstance
	{
		#region Cinccino Constructors
		/// <summary>
		/// Cinccino Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cinccino(string nickname, int level)
		: base(
				CinccinoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cinccino Constructor only waiting for a Level
		/// </summary>
		public Cinccino(int level)
		: this( "Cinccino", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cinccino Constructor waiting for no params
		/// </summary>
		/*
		public Cinccino() : this( "Cinccino", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}