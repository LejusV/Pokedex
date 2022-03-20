using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Swinub PokemonInstance Class
	#region Swinub
	public class Swinub : PokemonInstance
	{
		#region Swinub Constructors
		/// <summary>
		/// Swinub Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Swinub(string nickname, int level)
		: base(
				SwinubSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swinub Constructor only waiting for a Level
		/// </summary>
		public Swinub(int level)
		: this( "Swinub", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swinub Constructor waiting for no params
		/// </summary>
		/*
		public Swinub() : this( "Swinub", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}