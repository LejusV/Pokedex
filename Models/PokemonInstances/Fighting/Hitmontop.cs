using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hitmontop PokemonInstance Class
	#region Hitmontop
	public class Hitmontop : PokemonInstance
	{
		#region Hitmontop Constructors
		/// <summary>
		/// Hitmontop Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Hitmontop(string nickname, int level)
		: base(
				HitmontopSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmontop Constructor only waiting for a Level
		/// </summary>
		public Hitmontop(int level)
		: this( "Hitmontop", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmontop Constructor waiting for no params
		/// </summary>
		/*
		public Hitmontop() : this( "Hitmontop", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}