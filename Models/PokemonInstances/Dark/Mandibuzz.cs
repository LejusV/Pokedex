using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mandibuzz PokemonInstance Class
	#region Mandibuzz
	public class Mandibuzz : PokemonInstance
	{
		#region Mandibuzz Constructors
		/// <summary>
		/// Mandibuzz Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mandibuzz(string nickname, int level)
		: base(
				MandibuzzSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mandibuzz Constructor only waiting for a Level
		/// </summary>
		public Mandibuzz(int level)
		: this( "Mandibuzz", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mandibuzz Constructor waiting for no params
		/// </summary>
		/*
		public Mandibuzz() : this( "Mandibuzz", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}