using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lileep PokemonInstance Class
	#region Lileep
	public class Lileep : PokemonInstance
	{
		#region Lileep Constructors
		/// <summary>
		/// Lileep Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lileep(string nickname, int level)
		: base(
				LileepSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lileep Constructor only waiting for a Level
		/// </summary>
		public Lileep(int level)
		: this( "Lileep", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lileep Constructor waiting for no params
		/// </summary>
		/*
		public Lileep() : this( "Lileep", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}