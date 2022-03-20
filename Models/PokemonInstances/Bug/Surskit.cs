using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Surskit PokemonInstance Class
	#region Surskit
	public class Surskit : PokemonInstance
	{
		#region Surskit Constructors
		/// <summary>
		/// Surskit Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Surskit(string nickname, int level)
		: base(
				SurskitSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Surskit Constructor only waiting for a Level
		/// </summary>
		public Surskit(int level)
		: this( "Surskit", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Surskit Constructor waiting for no params
		/// </summary>
		/*
		public Surskit() : this( "Surskit", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}