using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dragonite PokemonInstance Class
	#region Dragonite
	public class Dragonite : PokemonInstance
	{
		#region Dragonite Constructors
		/// <summary>
		/// Dragonite Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dragonite(string nickname, int level)
		: base(
				DragoniteSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragonite Constructor only waiting for a Level
		/// </summary>
		public Dragonite(int level)
		: this( "Dragonite", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragonite Constructor waiting for no params
		/// </summary>
		/*
		public Dragonite() : this( "Dragonite", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}