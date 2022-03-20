using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Shiinotic PokemonInstance Class
	#region Shiinotic
	public class Shiinotic : PokemonInstance
	{
		#region Shiinotic Constructors
		/// <summary>
		/// Shiinotic Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Shiinotic(string nickname, int level)
		: base(
				ShiinoticSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shiinotic Constructor only waiting for a Level
		/// </summary>
		public Shiinotic(int level)
		: this( "Shiinotic", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shiinotic Constructor waiting for no params
		/// </summary>
		/*
		public Shiinotic() : this( "Shiinotic", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}