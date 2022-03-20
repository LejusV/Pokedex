using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sandaconda PokemonInstance Class
	#region Sandaconda
	public class Sandaconda : PokemonInstance
	{
		#region Sandaconda Constructors
		/// <summary>
		/// Sandaconda Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sandaconda(string nickname, int level)
		: base(
				SandacondaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandaconda Constructor only waiting for a Level
		/// </summary>
		public Sandaconda(int level)
		: this( "Sandaconda", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandaconda Constructor waiting for no params
		/// </summary>
		/*
		public Sandaconda() : this( "Sandaconda", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}