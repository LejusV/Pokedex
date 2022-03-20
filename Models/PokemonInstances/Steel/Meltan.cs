using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Meltan PokemonInstance Class
	#region Meltan
	public class Meltan : PokemonInstance
	{
		#region Meltan Constructors
		/// <summary>
		/// Meltan Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Meltan(string nickname, int level)
		: base(
				MeltanSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meltan Constructor only waiting for a Level
		/// </summary>
		public Meltan(int level)
		: this( "Meltan", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meltan Constructor waiting for no params
		/// </summary>
		/*
		public Meltan() : this( "Meltan", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}