using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Flapple PokemonInstance Class
	#region Flapple
	public class Flapple : PokemonInstance
	{
		#region Flapple Constructors
		/// <summary>
		/// Flapple Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Flapple(string nickname, int level)
		: base(
				FlappleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flapple Constructor only waiting for a Level
		/// </summary>
		public Flapple(int level)
		: this( "Flapple", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flapple Constructor waiting for no params
		/// </summary>
		/*
		public Flapple() : this( "Flapple", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}