using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Grimmsnarl PokemonInstance Class
	#region Grimmsnarl
	public class Grimmsnarl : PokemonInstance
	{
		#region Grimmsnarl Constructors
		/// <summary>
		/// Grimmsnarl Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Grimmsnarl(string nickname, int level)
		: base(
				GrimmsnarlSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grimmsnarl Constructor only waiting for a Level
		/// </summary>
		public Grimmsnarl(int level)
		: this( "Grimmsnarl", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grimmsnarl Constructor waiting for no params
		/// </summary>
		/*
		public Grimmsnarl() : this( "Grimmsnarl", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}