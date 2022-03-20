using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Shelmet PokemonInstance Class
	#region Shelmet
	public class Shelmet : PokemonInstance
	{
		#region Shelmet Constructors
		/// <summary>
		/// Shelmet Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Shelmet(string nickname, int level)
		: base(
				ShelmetSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shelmet Constructor only waiting for a Level
		/// </summary>
		public Shelmet(int level)
		: this( "Shelmet", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shelmet Constructor waiting for no params
		/// </summary>
		/*
		public Shelmet() : this( "Shelmet", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}