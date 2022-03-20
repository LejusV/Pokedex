using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Poochyena PokemonInstance Class
	#region Poochyena
	public class Poochyena : PokemonInstance
	{
		#region Poochyena Constructors
		/// <summary>
		/// Poochyena Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Poochyena(string nickname, int level)
		: base(
				PoochyenaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poochyena Constructor only waiting for a Level
		/// </summary>
		public Poochyena(int level)
		: this( "Poochyena", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poochyena Constructor waiting for no params
		/// </summary>
		/*
		public Poochyena() : this( "Poochyena", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}