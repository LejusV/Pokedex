using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Garchomp PokemonInstance Class
	#region Garchomp
	public class Garchomp : PokemonInstance
	{
		#region Garchomp Constructors
		/// <summary>
		/// Garchomp Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Garchomp(string nickname, int level)
		: base(
				GarchompSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Garchomp Constructor only waiting for a Level
		/// </summary>
		public Garchomp(int level)
		: this( "Garchomp", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Garchomp Constructor waiting for no params
		/// </summary>
		/*
		public Garchomp() : this( "Garchomp", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}