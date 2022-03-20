using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Plusle PokemonInstance Class
	#region Plusle
	public class Plusle : PokemonInstance
	{
		#region Plusle Constructors
		/// <summary>
		/// Plusle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Plusle(string nickname, int level)
		: base(
				PlusleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Plusle Constructor only waiting for a Level
		/// </summary>
		public Plusle(int level)
		: this( "Plusle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Plusle Constructor waiting for no params
		/// </summary>
		/*
		public Plusle() : this( "Plusle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}