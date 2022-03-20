using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Shinx PokemonInstance Class
	#region Shinx
	public class Shinx : PokemonInstance
	{
		#region Shinx Constructors
		/// <summary>
		/// Shinx Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Shinx(string nickname, int level)
		: base(
				ShinxSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shinx Constructor only waiting for a Level
		/// </summary>
		public Shinx(int level)
		: this( "Shinx", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shinx Constructor waiting for no params
		/// </summary>
		/*
		public Shinx() : this( "Shinx", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}