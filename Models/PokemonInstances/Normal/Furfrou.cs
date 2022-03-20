using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Furfrou PokemonInstance Class
	#region Furfrou
	public class Furfrou : PokemonInstance
	{
		#region Furfrou Constructors
		/// <summary>
		/// Furfrou Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Furfrou(string nickname, int level)
		: base(
				FurfrouSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Furfrou Constructor only waiting for a Level
		/// </summary>
		public Furfrou(int level)
		: this( "Furfrou", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Furfrou Constructor waiting for no params
		/// </summary>
		/*
		public Furfrou() : this( "Furfrou", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}