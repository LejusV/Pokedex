using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pikipek PokemonInstance Class
	#region Pikipek
	public class Pikipek : PokemonInstance
	{
		#region Pikipek Constructors
		/// <summary>
		/// Pikipek Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pikipek(string nickname, int level)
		: base(
				PikipekSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pikipek Constructor only waiting for a Level
		/// </summary>
		public Pikipek(int level)
		: this( "Pikipek", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pikipek Constructor waiting for no params
		/// </summary>
		/*
		public Pikipek() : this( "Pikipek", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}