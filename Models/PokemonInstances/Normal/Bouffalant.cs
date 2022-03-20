using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bouffalant PokemonInstance Class
	#region Bouffalant
	public class Bouffalant : PokemonInstance
	{
		#region Bouffalant Constructors
		/// <summary>
		/// Bouffalant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bouffalant(string nickname, int level)
		: base(
				BouffalantSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bouffalant Constructor only waiting for a Level
		/// </summary>
		public Bouffalant(int level)
		: this( "Bouffalant", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bouffalant Constructor waiting for no params
		/// </summary>
		/*
		public Bouffalant() : this( "Bouffalant", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}