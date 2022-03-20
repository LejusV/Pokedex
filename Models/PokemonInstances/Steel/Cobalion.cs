using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cobalion PokemonInstance Class
	#region Cobalion
	public class Cobalion : PokemonInstance
	{
		#region Cobalion Constructors
		/// <summary>
		/// Cobalion Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cobalion(string nickname, int level)
		: base(
				CobalionSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cobalion Constructor only waiting for a Level
		/// </summary>
		public Cobalion(int level)
		: this( "Cobalion", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cobalion Constructor waiting for no params
		/// </summary>
		/*
		public Cobalion() : this( "Cobalion", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}