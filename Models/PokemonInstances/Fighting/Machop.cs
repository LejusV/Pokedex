using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Machop PokemonInstance Class
	#region Machop
	public class Machop : PokemonInstance
	{
		#region Machop Constructors
		/// <summary>
		/// Machop Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Machop(string nickname, int level)
		: base(
				MachopSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machop Constructor only waiting for a Level
		/// </summary>
		public Machop(int level)
		: this( "Machop", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machop Constructor waiting for no params
		/// </summary>
		/*
		public Machop() : this( "Machop", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}