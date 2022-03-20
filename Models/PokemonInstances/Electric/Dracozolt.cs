using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dracozolt PokemonInstance Class
	#region Dracozolt
	public class Dracozolt : PokemonInstance
	{
		#region Dracozolt Constructors
		/// <summary>
		/// Dracozolt Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dracozolt(string nickname, int level)
		: base(
				DracozoltSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dracozolt Constructor only waiting for a Level
		/// </summary>
		public Dracozolt(int level)
		: this( "Dracozolt", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dracozolt Constructor waiting for no params
		/// </summary>
		/*
		public Dracozolt() : this( "Dracozolt", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}