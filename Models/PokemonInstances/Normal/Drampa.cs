using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Drampa PokemonInstance Class
	#region Drampa
	public class Drampa : PokemonInstance
	{
		#region Drampa Constructors
		/// <summary>
		/// Drampa Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Drampa(string nickname, int level)
		: base(
				DrampaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drampa Constructor only waiting for a Level
		/// </summary>
		public Drampa(int level)
		: this( "Drampa", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drampa Constructor waiting for no params
		/// </summary>
		/*
		public Drampa() : this( "Drampa", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}