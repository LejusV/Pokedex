using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Camerupt PokemonInstance Class
	#region Camerupt
	public class Camerupt : PokemonInstance
	{
		#region Camerupt Constructors
		/// <summary>
		/// Camerupt Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Camerupt(string nickname, int level)
		: base(
				CameruptSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Camerupt Constructor only waiting for a Level
		/// </summary>
		public Camerupt(int level)
		: this( "Camerupt", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Camerupt Constructor waiting for no params
		/// </summary>
		/*
		public Camerupt() : this( "Camerupt", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}