using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Onix PokemonInstance Class
	#region Onix
	public class Onix : PokemonInstance
	{
		#region Onix Constructors
		/// <summary>
		/// Onix Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Onix(string nickname, int level)
		: base(
				OnixSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Onix Constructor only waiting for a Level
		/// </summary>
		public Onix(int level)
		: this( "Onix", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Onix Constructor waiting for no params
		/// </summary>
		/*
		public Onix() : this( "Onix", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}