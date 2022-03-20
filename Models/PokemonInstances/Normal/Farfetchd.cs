using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Farfetchd PokemonInstance Class
	#region Farfetchd
	public class Farfetchd : PokemonInstance
	{
		#region Farfetchd Constructors
		/// <summary>
		/// Farfetchd Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Farfetchd(string nickname, int level)
		: base(
				FarfetchdSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Farfetchd Constructor only waiting for a Level
		/// </summary>
		public Farfetchd(int level)
		: this( "Farfetchd", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Farfetchd Constructor waiting for no params
		/// </summary>
		/*
		public Farfetchd() : this( "Farfetchd", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}