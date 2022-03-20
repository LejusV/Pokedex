using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tepig PokemonInstance Class
	#region Tepig
	public class Tepig : PokemonInstance
	{
		#region Tepig Constructors
		/// <summary>
		/// Tepig Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tepig(string nickname, int level)
		: base(
				TepigSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tepig Constructor only waiting for a Level
		/// </summary>
		public Tepig(int level)
		: this( "Tepig", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tepig Constructor waiting for no params
		/// </summary>
		/*
		public Tepig() : this( "Tepig", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}