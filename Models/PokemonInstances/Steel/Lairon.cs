using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lairon PokemonInstance Class
	#region Lairon
	public class Lairon : PokemonInstance
	{
		#region Lairon Constructors
		/// <summary>
		/// Lairon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lairon(string nickname, int level)
		: base(
				LaironSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lairon Constructor only waiting for a Level
		/// </summary>
		public Lairon(int level)
		: this( "Lairon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lairon Constructor waiting for no params
		/// </summary>
		/*
		public Lairon() : this( "Lairon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}