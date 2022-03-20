using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Piplup PokemonInstance Class
	#region Piplup
	public class Piplup : PokemonInstance
	{
		#region Piplup Constructors
		/// <summary>
		/// Piplup Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Piplup(string nickname, int level)
		: base(
				PiplupSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Piplup Constructor only waiting for a Level
		/// </summary>
		public Piplup(int level)
		: this( "Piplup", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Piplup Constructor waiting for no params
		/// </summary>
		/*
		public Piplup() : this( "Piplup", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}