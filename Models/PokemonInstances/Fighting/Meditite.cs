using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Meditite PokemonInstance Class
	#region Meditite
	public class Meditite : PokemonInstance
	{
		#region Meditite Constructors
		/// <summary>
		/// Meditite Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Meditite(string nickname, int level)
		: base(
				MedititeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meditite Constructor only waiting for a Level
		/// </summary>
		public Meditite(int level)
		: this( "Meditite", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meditite Constructor waiting for no params
		/// </summary>
		/*
		public Meditite() : this( "Meditite", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}