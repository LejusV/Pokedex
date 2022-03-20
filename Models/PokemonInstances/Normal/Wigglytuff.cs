using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Wigglytuff PokemonInstance Class
	#region Wigglytuff
	public class Wigglytuff : PokemonInstance
	{
		#region Wigglytuff Constructors
		/// <summary>
		/// Wigglytuff Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Wigglytuff(string nickname, int level)
		: base(
				WigglytuffSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wigglytuff Constructor only waiting for a Level
		/// </summary>
		public Wigglytuff(int level)
		: this( "Wigglytuff", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wigglytuff Constructor waiting for no params
		/// </summary>
		/*
		public Wigglytuff() : this( "Wigglytuff", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}