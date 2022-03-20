using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Skitty PokemonInstance Class
	#region Skitty
	public class Skitty : PokemonInstance
	{
		#region Skitty Constructors
		/// <summary>
		/// Skitty Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Skitty(string nickname, int level)
		: base(
				SkittySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skitty Constructor only waiting for a Level
		/// </summary>
		public Skitty(int level)
		: this( "Skitty", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skitty Constructor waiting for no params
		/// </summary>
		/*
		public Skitty() : this( "Skitty", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}