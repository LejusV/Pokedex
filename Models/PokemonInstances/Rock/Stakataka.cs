using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Stakataka PokemonInstance Class
	#region Stakataka
	public class Stakataka : PokemonInstance
	{
		#region Stakataka Constructors
		/// <summary>
		/// Stakataka Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Stakataka(string nickname, int level)
		: base(
				StakatakaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stakataka Constructor only waiting for a Level
		/// </summary>
		public Stakataka(int level)
		: this( "Stakataka", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stakataka Constructor waiting for no params
		/// </summary>
		/*
		public Stakataka() : this( "Stakataka", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}