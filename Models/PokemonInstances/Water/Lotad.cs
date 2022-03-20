using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lotad PokemonInstance Class
	#region Lotad
	public class Lotad : PokemonInstance
	{
		#region Lotad Constructors
		/// <summary>
		/// Lotad Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lotad(string nickname, int level)
		: base(
				LotadSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lotad Constructor only waiting for a Level
		/// </summary>
		public Lotad(int level)
		: this( "Lotad", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lotad Constructor waiting for no params
		/// </summary>
		/*
		public Lotad() : this( "Lotad", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}