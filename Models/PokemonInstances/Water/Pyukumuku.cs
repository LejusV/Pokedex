using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pyukumuku PokemonInstance Class
	#region Pyukumuku
	public class Pyukumuku : PokemonInstance
	{
		#region Pyukumuku Constructors
		/// <summary>
		/// Pyukumuku Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pyukumuku(string nickname, int level)
		: base(
				PyukumukuSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pyukumuku Constructor only waiting for a Level
		/// </summary>
		public Pyukumuku(int level)
		: this( "Pyukumuku", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pyukumuku Constructor waiting for no params
		/// </summary>
		/*
		public Pyukumuku() : this( "Pyukumuku", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}