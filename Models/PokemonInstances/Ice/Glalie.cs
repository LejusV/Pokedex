using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Glalie PokemonInstance Class
	#region Glalie
	public class Glalie : PokemonInstance
	{
		#region Glalie Constructors
		/// <summary>
		/// Glalie Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Glalie(string nickname, int level)
		: base(
				GlalieSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glalie Constructor only waiting for a Level
		/// </summary>
		public Glalie(int level)
		: this( "Glalie", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glalie Constructor waiting for no params
		/// </summary>
		/*
		public Glalie() : this( "Glalie", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}