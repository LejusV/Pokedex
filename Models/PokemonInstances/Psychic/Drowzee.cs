using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Drowzee PokemonInstance Class
	#region Drowzee
	public class Drowzee : PokemonInstance
	{
		#region Drowzee Constructors
		/// <summary>
		/// Drowzee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Drowzee(string nickname, int level)
		: base(
				DrowzeeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drowzee Constructor only waiting for a Level
		/// </summary>
		public Drowzee(int level)
		: this( "Drowzee", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drowzee Constructor waiting for no params
		/// </summary>
		/*
		public Drowzee() : this( "Drowzee", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}