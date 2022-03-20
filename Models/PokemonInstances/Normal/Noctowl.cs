using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Noctowl PokemonInstance Class
	#region Noctowl
	public class Noctowl : PokemonInstance
	{
		#region Noctowl Constructors
		/// <summary>
		/// Noctowl Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Noctowl(string nickname, int level)
		: base(
				NoctowlSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noctowl Constructor only waiting for a Level
		/// </summary>
		public Noctowl(int level)
		: this( "Noctowl", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noctowl Constructor waiting for no params
		/// </summary>
		/*
		public Noctowl() : this( "Noctowl", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}