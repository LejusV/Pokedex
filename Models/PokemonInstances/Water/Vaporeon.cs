using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Vaporeon PokemonInstance Class
	#region Vaporeon
	public class Vaporeon : PokemonInstance
	{
		#region Vaporeon Constructors
		/// <summary>
		/// Vaporeon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Vaporeon(string nickname, int level)
		: base(
				VaporeonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vaporeon Constructor only waiting for a Level
		/// </summary>
		public Vaporeon(int level)
		: this( "Vaporeon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vaporeon Constructor waiting for no params
		/// </summary>
		/*
		public Vaporeon() : this( "Vaporeon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}