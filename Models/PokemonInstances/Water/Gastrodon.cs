using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gastrodon PokemonInstance Class
	#region Gastrodon
	public class Gastrodon : PokemonInstance
	{
		#region Gastrodon Constructors
		/// <summary>
		/// Gastrodon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gastrodon(string nickname, int level)
		: base(
				GastrodonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gastrodon Constructor only waiting for a Level
		/// </summary>
		public Gastrodon(int level)
		: this( "Gastrodon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gastrodon Constructor waiting for no params
		/// </summary>
		/*
		public Gastrodon() : this( "Gastrodon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}