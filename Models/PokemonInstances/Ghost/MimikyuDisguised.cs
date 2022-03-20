using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mimikyu-Disguised PokemonInstance Class
	#region Mimikyu-Disguised
	public class MimikyuDisguised : PokemonInstance
	{
		#region Mimikyu-Disguised Constructors
		/// <summary>
		/// Mimikyu-Disguised Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MimikyuDisguised(string nickname, int level)
		: base(
				MimikyuDisguisedSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mimikyu-Disguised Constructor only waiting for a Level
		/// </summary>
		public MimikyuDisguised(int level)
		: this( "Mimikyu-Disguised", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mimikyu-Disguised Constructor waiting for no params
		/// </summary>
		/*
		public MimikyuDisguised() : this( "Mimikyu-Disguised", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}