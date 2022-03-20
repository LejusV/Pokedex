using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lumineon PokemonInstance Class
	#region Lumineon
	public class Lumineon : PokemonInstance
	{
		#region Lumineon Constructors
		/// <summary>
		/// Lumineon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lumineon(string nickname, int level)
		: base(
				LumineonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lumineon Constructor only waiting for a Level
		/// </summary>
		public Lumineon(int level)
		: this( "Lumineon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lumineon Constructor waiting for no params
		/// </summary>
		/*
		public Lumineon() : this( "Lumineon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}