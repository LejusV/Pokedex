using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Rolycoly PokemonInstance Class
	#region Rolycoly
	public class Rolycoly : PokemonInstance
	{
		#region Rolycoly Constructors
		/// <summary>
		/// Rolycoly Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Rolycoly(string nickname, int level)
		: base(
				RolycolySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rolycoly Constructor only waiting for a Level
		/// </summary>
		public Rolycoly(int level)
		: this( "Rolycoly", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rolycoly Constructor waiting for no params
		/// </summary>
		/*
		public Rolycoly() : this( "Rolycoly", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}