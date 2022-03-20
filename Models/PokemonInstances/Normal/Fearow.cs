using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Fearow PokemonInstance Class
	#region Fearow
	public class Fearow : PokemonInstance
	{
		#region Fearow Constructors
		/// <summary>
		/// Fearow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Fearow(string nickname, int level)
		: base(
				FearowSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fearow Constructor only waiting for a Level
		/// </summary>
		public Fearow(int level)
		: this( "Fearow", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fearow Constructor waiting for no params
		/// </summary>
		/*
		public Fearow() : this( "Fearow", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}