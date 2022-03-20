using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Boltund PokemonInstance Class
	#region Boltund
	public class Boltund : PokemonInstance
	{
		#region Boltund Constructors
		/// <summary>
		/// Boltund Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Boltund(string nickname, int level)
		: base(
				BoltundSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Boltund Constructor only waiting for a Level
		/// </summary>
		public Boltund(int level)
		: this( "Boltund", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Boltund Constructor waiting for no params
		/// </summary>
		/*
		public Boltund() : this( "Boltund", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}