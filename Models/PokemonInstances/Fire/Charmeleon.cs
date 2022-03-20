using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Charmeleon PokemonInstance Class
	#region Charmeleon
	public class Charmeleon : PokemonInstance
	{
		#region Charmeleon Constructors
		/// <summary>
		/// Charmeleon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Charmeleon(string nickname, int level)
		: base(
				CharmeleonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charmeleon Constructor only waiting for a Level
		/// </summary>
		public Charmeleon(int level)
		: this( "Charmeleon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charmeleon Constructor waiting for no params
		/// </summary>
		/*
		public Charmeleon() : this( "Charmeleon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}