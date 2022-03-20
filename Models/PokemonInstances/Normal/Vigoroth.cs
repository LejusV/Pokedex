using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Vigoroth PokemonInstance Class
	#region Vigoroth
	public class Vigoroth : PokemonInstance
	{
		#region Vigoroth Constructors
		/// <summary>
		/// Vigoroth Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Vigoroth(string nickname, int level)
		: base(
				VigorothSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vigoroth Constructor only waiting for a Level
		/// </summary>
		public Vigoroth(int level)
		: this( "Vigoroth", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vigoroth Constructor waiting for no params
		/// </summary>
		/*
		public Vigoroth() : this( "Vigoroth", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}