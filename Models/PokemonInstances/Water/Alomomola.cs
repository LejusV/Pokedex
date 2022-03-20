using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Alomomola PokemonInstance Class
	#region Alomomola
	public class Alomomola : PokemonInstance
	{
		#region Alomomola Constructors
		/// <summary>
		/// Alomomola Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Alomomola(string nickname, int level)
		: base(
				AlomomolaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alomomola Constructor only waiting for a Level
		/// </summary>
		public Alomomola(int level)
		: this( "Alomomola", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alomomola Constructor waiting for no params
		/// </summary>
		/*
		public Alomomola() : this( "Alomomola", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}