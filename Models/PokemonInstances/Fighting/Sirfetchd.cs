using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sirfetchd PokemonInstance Class
	#region Sirfetchd
	public class Sirfetchd : PokemonInstance
	{
		#region Sirfetchd Constructors
		/// <summary>
		/// Sirfetchd Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sirfetchd(string nickname, int level)
		: base(
				SirfetchdSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sirfetchd Constructor only waiting for a Level
		/// </summary>
		public Sirfetchd(int level)
		: this( "Sirfetchd", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sirfetchd Constructor waiting for no params
		/// </summary>
		/*
		public Sirfetchd() : this( "Sirfetchd", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}