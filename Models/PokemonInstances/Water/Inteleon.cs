using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Inteleon PokemonInstance Class
	#region Inteleon
	public class Inteleon : PokemonInstance
	{
		#region Inteleon Constructors
		/// <summary>
		/// Inteleon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Inteleon(string nickname, int level)
		: base(
				InteleonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Inteleon Constructor only waiting for a Level
		/// </summary>
		public Inteleon(int level)
		: this( "Inteleon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Inteleon Constructor waiting for no params
		/// </summary>
		/*
		public Inteleon() : this( "Inteleon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}