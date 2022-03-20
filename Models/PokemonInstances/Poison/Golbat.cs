using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Golbat PokemonInstance Class
	#region Golbat
	public class Golbat : PokemonInstance
	{
		#region Golbat Constructors
		/// <summary>
		/// Golbat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Golbat(string nickname, int level)
		: base(
				GolbatSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golbat Constructor only waiting for a Level
		/// </summary>
		public Golbat(int level)
		: this( "Golbat", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golbat Constructor waiting for no params
		/// </summary>
		/*
		public Golbat() : this( "Golbat", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}