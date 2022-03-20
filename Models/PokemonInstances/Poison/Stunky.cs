using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Stunky PokemonInstance Class
	#region Stunky
	public class Stunky : PokemonInstance
	{
		#region Stunky Constructors
		/// <summary>
		/// Stunky Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Stunky(string nickname, int level)
		: base(
				StunkySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stunky Constructor only waiting for a Level
		/// </summary>
		public Stunky(int level)
		: this( "Stunky", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stunky Constructor waiting for no params
		/// </summary>
		/*
		public Stunky() : this( "Stunky", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}