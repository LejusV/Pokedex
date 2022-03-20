using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Geodude PokemonInstance Class
	#region Geodude
	public class Geodude : PokemonInstance
	{
		#region Geodude Constructors
		/// <summary>
		/// Geodude Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Geodude(string nickname, int level)
		: base(
				GeodudeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Geodude Constructor only waiting for a Level
		/// </summary>
		public Geodude(int level)
		: this( "Geodude", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Geodude Constructor waiting for no params
		/// </summary>
		/*
		public Geodude() : this( "Geodude", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}