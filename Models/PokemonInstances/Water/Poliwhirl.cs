using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Poliwhirl PokemonInstance Class
	#region Poliwhirl
	public class Poliwhirl : PokemonInstance
	{
		#region Poliwhirl Constructors
		/// <summary>
		/// Poliwhirl Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Poliwhirl(string nickname, int level)
		: base(
				PoliwhirlSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwhirl Constructor only waiting for a Level
		/// </summary>
		public Poliwhirl(int level)
		: this( "Poliwhirl", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwhirl Constructor waiting for no params
		/// </summary>
		/*
		public Poliwhirl() : this( "Poliwhirl", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}