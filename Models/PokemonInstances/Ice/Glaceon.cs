using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Glaceon PokemonInstance Class
	#region Glaceon
	public class Glaceon : PokemonInstance
	{
		#region Glaceon Constructors
		/// <summary>
		/// Glaceon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Glaceon(string nickname, int level)
		: base(
				GlaceonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glaceon Constructor only waiting for a Level
		/// </summary>
		public Glaceon(int level)
		: this( "Glaceon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glaceon Constructor waiting for no params
		/// </summary>
		/*
		public Glaceon() : this( "Glaceon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}