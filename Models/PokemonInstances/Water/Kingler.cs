using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kingler PokemonInstance Class
	#region Kingler
	public class Kingler : PokemonInstance
	{
		#region Kingler Constructors
		/// <summary>
		/// Kingler Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Kingler(string nickname, int level)
		: base(
				KinglerSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kingler Constructor only waiting for a Level
		/// </summary>
		public Kingler(int level)
		: this( "Kingler", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kingler Constructor waiting for no params
		/// </summary>
		/*
		public Kingler() : this( "Kingler", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}