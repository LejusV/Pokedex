using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Empoleon PokemonInstance Class
	#region Empoleon
	public class Empoleon : PokemonInstance
	{
		#region Empoleon Constructors
		/// <summary>
		/// Empoleon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Empoleon(string nickname, int level)
		: base(
				EmpoleonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Empoleon Constructor only waiting for a Level
		/// </summary>
		public Empoleon(int level)
		: this( "Empoleon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Empoleon Constructor waiting for no params
		/// </summary>
		/*
		public Empoleon() : this( "Empoleon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}