using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Buizel PokemonInstance Class
	#region Buizel
	public class Buizel : PokemonInstance
	{
		#region Buizel Constructors
		/// <summary>
		/// Buizel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Buizel(string nickname, int level)
		: base(
				BuizelSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buizel Constructor only waiting for a Level
		/// </summary>
		public Buizel(int level)
		: this( "Buizel", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buizel Constructor waiting for no params
		/// </summary>
		/*
		public Buizel() : this( "Buizel", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}