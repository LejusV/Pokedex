using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Goldeen PokemonInstance Class
	#region Goldeen
	public class Goldeen : PokemonInstance
	{
		#region Goldeen Constructors
		/// <summary>
		/// Goldeen Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Goldeen(string nickname, int level)
		: base(
				GoldeenSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goldeen Constructor only waiting for a Level
		/// </summary>
		public Goldeen(int level)
		: this( "Goldeen", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goldeen Constructor waiting for no params
		/// </summary>
		/*
		public Goldeen() : this( "Goldeen", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}