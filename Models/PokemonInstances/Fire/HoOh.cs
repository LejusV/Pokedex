using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ho-Oh PokemonInstance Class
	#region Ho-Oh
	public class HoOh : PokemonInstance
	{
		#region Ho-Oh Constructors
		/// <summary>
		/// Ho-Oh Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HoOh(string nickname, int level)
		: base(
				HoOhSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ho-Oh Constructor only waiting for a Level
		/// </summary>
		public HoOh(int level)
		: this( "Ho-Oh", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ho-Oh Constructor waiting for no params
		/// </summary>
		/*
		public HoOh() : this( "Ho-Oh", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}