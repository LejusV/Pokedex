using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Buzzwole PokemonInstance Class
	#region Buzzwole
	public class Buzzwole : PokemonInstance
	{
		#region Buzzwole Constructors
		/// <summary>
		/// Buzzwole Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Buzzwole(string nickname, int level)
		: base(
				BuzzwoleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buzzwole Constructor only waiting for a Level
		/// </summary>
		public Buzzwole(int level)
		: this( "Buzzwole", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buzzwole Constructor waiting for no params
		/// </summary>
		/*
		public Buzzwole() : this( "Buzzwole", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}