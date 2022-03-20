using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Arctovish PokemonInstance Class
	#region Arctovish
	public class Arctovish : PokemonInstance
	{
		#region Arctovish Constructors
		/// <summary>
		/// Arctovish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Arctovish(string nickname, int level)
		: base(
				ArctovishSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arctovish Constructor only waiting for a Level
		/// </summary>
		public Arctovish(int level)
		: this( "Arctovish", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arctovish Constructor waiting for no params
		/// </summary>
		/*
		public Arctovish() : this( "Arctovish", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}