using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mawile PokemonInstance Class
	#region Mawile
	public class Mawile : PokemonInstance
	{
		#region Mawile Constructors
		/// <summary>
		/// Mawile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mawile(string nickname, int level)
		: base(
				MawileSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mawile Constructor only waiting for a Level
		/// </summary>
		public Mawile(int level)
		: this( "Mawile", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mawile Constructor waiting for no params
		/// </summary>
		/*
		public Mawile() : this( "Mawile", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}