using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Electabuzz PokemonInstance Class
	#region Electabuzz
	public class Electabuzz : PokemonInstance
	{
		#region Electabuzz Constructors
		/// <summary>
		/// Electabuzz Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Electabuzz(string nickname, int level)
		: base(
				ElectabuzzSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electabuzz Constructor only waiting for a Level
		/// </summary>
		public Electabuzz(int level)
		: this( "Electabuzz", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electabuzz Constructor waiting for no params
		/// </summary>
		/*
		public Electabuzz() : this( "Electabuzz", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}