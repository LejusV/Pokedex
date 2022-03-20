using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sandshrew PokemonInstance Class
	#region Sandshrew
	public class Sandshrew : PokemonInstance
	{
		#region Sandshrew Constructors
		/// <summary>
		/// Sandshrew Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sandshrew(string nickname, int level)
		: base(
				SandshrewSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandshrew Constructor only waiting for a Level
		/// </summary>
		public Sandshrew(int level)
		: this( "Sandshrew", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandshrew Constructor waiting for no params
		/// </summary>
		/*
		public Sandshrew() : this( "Sandshrew", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}