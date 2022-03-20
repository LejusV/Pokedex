using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Voltorb PokemonInstance Class
	#region Voltorb
	public class Voltorb : PokemonInstance
	{
		#region Voltorb Constructors
		/// <summary>
		/// Voltorb Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Voltorb(string nickname, int level)
		: base(
				VoltorbSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Voltorb Constructor only waiting for a Level
		/// </summary>
		public Voltorb(int level)
		: this( "Voltorb", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Voltorb Constructor waiting for no params
		/// </summary>
		/*
		public Voltorb() : this( "Voltorb", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}