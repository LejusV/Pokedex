using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Eldegoss PokemonInstance Class
	#region Eldegoss
	public class Eldegoss : PokemonInstance
	{
		#region Eldegoss Constructors
		/// <summary>
		/// Eldegoss Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Eldegoss(string nickname, int level)
		: base(
				EldegossSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eldegoss Constructor only waiting for a Level
		/// </summary>
		public Eldegoss(int level)
		: this( "Eldegoss", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eldegoss Constructor waiting for no params
		/// </summary>
		/*
		public Eldegoss() : this( "Eldegoss", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}