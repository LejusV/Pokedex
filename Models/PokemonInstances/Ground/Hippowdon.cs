using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hippowdon PokemonInstance Class
	#region Hippowdon
	public class Hippowdon : PokemonInstance
	{
		#region Hippowdon Constructors
		/// <summary>
		/// Hippowdon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Hippowdon(string nickname, int level)
		: base(
				HippowdonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hippowdon Constructor only waiting for a Level
		/// </summary>
		public Hippowdon(int level)
		: this( "Hippowdon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hippowdon Constructor waiting for no params
		/// </summary>
		/*
		public Hippowdon() : this( "Hippowdon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}