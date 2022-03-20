using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Helioptile PokemonInstance Class
	#region Helioptile
	public class Helioptile : PokemonInstance
	{
		#region Helioptile Constructors
		/// <summary>
		/// Helioptile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Helioptile(string nickname, int level)
		: base(
				HelioptileSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Helioptile Constructor only waiting for a Level
		/// </summary>
		public Helioptile(int level)
		: this( "Helioptile", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Helioptile Constructor waiting for no params
		/// </summary>
		/*
		public Helioptile() : this( "Helioptile", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}