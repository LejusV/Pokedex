using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pineco PokemonInstance Class
	#region Pineco
	public class Pineco : PokemonInstance
	{
		#region Pineco Constructors
		/// <summary>
		/// Pineco Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pineco(string nickname, int level)
		: base(
				PinecoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pineco Constructor only waiting for a Level
		/// </summary>
		public Pineco(int level)
		: this( "Pineco", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pineco Constructor waiting for no params
		/// </summary>
		/*
		public Pineco() : this( "Pineco", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}