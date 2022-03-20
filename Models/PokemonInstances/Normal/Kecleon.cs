using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kecleon PokemonInstance Class
	#region Kecleon
	public class Kecleon : PokemonInstance
	{
		#region Kecleon Constructors
		/// <summary>
		/// Kecleon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Kecleon(string nickname, int level)
		: base(
				KecleonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kecleon Constructor only waiting for a Level
		/// </summary>
		public Kecleon(int level)
		: this( "Kecleon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kecleon Constructor waiting for no params
		/// </summary>
		/*
		public Kecleon() : this( "Kecleon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}