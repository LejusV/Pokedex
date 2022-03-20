using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Skwovet PokemonInstance Class
	#region Skwovet
	public class Skwovet : PokemonInstance
	{
		#region Skwovet Constructors
		/// <summary>
		/// Skwovet Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Skwovet(string nickname, int level)
		: base(
				SkwovetSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skwovet Constructor only waiting for a Level
		/// </summary>
		public Skwovet(int level)
		: this( "Skwovet", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skwovet Constructor waiting for no params
		/// </summary>
		/*
		public Skwovet() : this( "Skwovet", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}