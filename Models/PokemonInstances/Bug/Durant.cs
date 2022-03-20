using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Durant PokemonInstance Class
	#region Durant
	public class Durant : PokemonInstance
	{
		#region Durant Constructors
		/// <summary>
		/// Durant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Durant(string nickname, int level)
		: base(
				DurantSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Durant Constructor only waiting for a Level
		/// </summary>
		public Durant(int level)
		: this( "Durant", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Durant Constructor waiting for no params
		/// </summary>
		/*
		public Durant() : this( "Durant", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}