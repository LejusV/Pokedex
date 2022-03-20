using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kyogre PokemonInstance Class
	#region Kyogre
	public class Kyogre : PokemonInstance
	{
		#region Kyogre Constructors
		/// <summary>
		/// Kyogre Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Kyogre(string nickname, int level)
		: base(
				KyogreSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kyogre Constructor only waiting for a Level
		/// </summary>
		public Kyogre(int level)
		: this( "Kyogre", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kyogre Constructor waiting for no params
		/// </summary>
		/*
		public Kyogre() : this( "Kyogre", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}