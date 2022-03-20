using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Slowking PokemonInstance Class
	#region Slowking
	public class Slowking : PokemonInstance
	{
		#region Slowking Constructors
		/// <summary>
		/// Slowking Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Slowking(string nickname, int level)
		: base(
				SlowkingSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowking Constructor only waiting for a Level
		/// </summary>
		public Slowking(int level)
		: this( "Slowking", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowking Constructor waiting for no params
		/// </summary>
		/*
		public Slowking() : this( "Slowking", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}