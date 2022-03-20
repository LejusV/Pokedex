using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tropius PokemonInstance Class
	#region Tropius
	public class Tropius : PokemonInstance
	{
		#region Tropius Constructors
		/// <summary>
		/// Tropius Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tropius(string nickname, int level)
		: base(
				TropiusSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tropius Constructor only waiting for a Level
		/// </summary>
		public Tropius(int level)
		: this( "Tropius", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tropius Constructor waiting for no params
		/// </summary>
		/*
		public Tropius() : this( "Tropius", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}