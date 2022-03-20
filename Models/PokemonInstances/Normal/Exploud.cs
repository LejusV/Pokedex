using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Exploud PokemonInstance Class
	#region Exploud
	public class Exploud : PokemonInstance
	{
		#region Exploud Constructors
		/// <summary>
		/// Exploud Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Exploud(string nickname, int level)
		: base(
				ExploudSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exploud Constructor only waiting for a Level
		/// </summary>
		public Exploud(int level)
		: this( "Exploud", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exploud Constructor waiting for no params
		/// </summary>
		/*
		public Exploud() : this( "Exploud", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}