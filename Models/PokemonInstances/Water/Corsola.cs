using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Corsola PokemonInstance Class
	#region Corsola
	public class Corsola : PokemonInstance
	{
		#region Corsola Constructors
		/// <summary>
		/// Corsola Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Corsola(string nickname, int level)
		: base(
				CorsolaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corsola Constructor only waiting for a Level
		/// </summary>
		public Corsola(int level)
		: this( "Corsola", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corsola Constructor waiting for no params
		/// </summary>
		/*
		public Corsola() : this( "Corsola", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}