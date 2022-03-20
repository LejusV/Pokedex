using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Flareon PokemonInstance Class
	#region Flareon
	public class Flareon : PokemonInstance
	{
		#region Flareon Constructors
		/// <summary>
		/// Flareon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Flareon(string nickname, int level)
		: base(
				FlareonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flareon Constructor only waiting for a Level
		/// </summary>
		public Flareon(int level)
		: this( "Flareon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flareon Constructor waiting for no params
		/// </summary>
		/*
		public Flareon() : this( "Flareon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}