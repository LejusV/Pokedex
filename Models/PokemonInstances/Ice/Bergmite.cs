using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bergmite PokemonInstance Class
	#region Bergmite
	public class Bergmite : PokemonInstance
	{
		#region Bergmite Constructors
		/// <summary>
		/// Bergmite Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bergmite(string nickname, int level)
		: base(
				BergmiteSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bergmite Constructor only waiting for a Level
		/// </summary>
		public Bergmite(int level)
		: this( "Bergmite", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bergmite Constructor waiting for no params
		/// </summary>
		/*
		public Bergmite() : this( "Bergmite", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}