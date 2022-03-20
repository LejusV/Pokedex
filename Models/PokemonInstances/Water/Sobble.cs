using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sobble PokemonInstance Class
	#region Sobble
	public class Sobble : PokemonInstance
	{
		#region Sobble Constructors
		/// <summary>
		/// Sobble Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sobble(string nickname, int level)
		: base(
				SobbleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sobble Constructor only waiting for a Level
		/// </summary>
		public Sobble(int level)
		: this( "Sobble", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sobble Constructor waiting for no params
		/// </summary>
		/*
		public Sobble() : this( "Sobble", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}