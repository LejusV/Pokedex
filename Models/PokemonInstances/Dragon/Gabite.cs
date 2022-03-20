using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gabite PokemonInstance Class
	#region Gabite
	public class Gabite : PokemonInstance
	{
		#region Gabite Constructors
		/// <summary>
		/// Gabite Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gabite(string nickname, int level)
		: base(
				GabiteSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gabite Constructor only waiting for a Level
		/// </summary>
		public Gabite(int level)
		: this( "Gabite", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gabite Constructor waiting for no params
		/// </summary>
		/*
		public Gabite() : this( "Gabite", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}