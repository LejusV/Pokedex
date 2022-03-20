using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Palossand PokemonInstance Class
	#region Palossand
	public class Palossand : PokemonInstance
	{
		#region Palossand Constructors
		/// <summary>
		/// Palossand Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Palossand(string nickname, int level)
		: base(
				PalossandSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palossand Constructor only waiting for a Level
		/// </summary>
		public Palossand(int level)
		: this( "Palossand", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palossand Constructor waiting for no params
		/// </summary>
		/*
		public Palossand() : this( "Palossand", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}