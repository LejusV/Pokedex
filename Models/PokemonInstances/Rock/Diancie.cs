using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Diancie PokemonInstance Class
	#region Diancie
	public class Diancie : PokemonInstance
	{
		#region Diancie Constructors
		/// <summary>
		/// Diancie Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Diancie(string nickname, int level)
		: base(
				DiancieSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diancie Constructor only waiting for a Level
		/// </summary>
		public Diancie(int level)
		: this( "Diancie", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diancie Constructor waiting for no params
		/// </summary>
		/*
		public Diancie() : this( "Diancie", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}