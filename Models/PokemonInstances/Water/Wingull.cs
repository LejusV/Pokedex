using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Wingull PokemonInstance Class
	#region Wingull
	public class Wingull : PokemonInstance
	{
		#region Wingull Constructors
		/// <summary>
		/// Wingull Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Wingull(string nickname, int level)
		: base(
				WingullSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wingull Constructor only waiting for a Level
		/// </summary>
		public Wingull(int level)
		: this( "Wingull", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wingull Constructor waiting for no params
		/// </summary>
		/*
		public Wingull() : this( "Wingull", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}