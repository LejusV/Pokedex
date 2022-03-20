using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pinsir PokemonInstance Class
	#region Pinsir
	public class Pinsir : PokemonInstance
	{
		#region Pinsir Constructors
		/// <summary>
		/// Pinsir Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pinsir(string nickname, int level)
		: base(
				PinsirSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pinsir Constructor only waiting for a Level
		/// </summary>
		public Pinsir(int level)
		: this( "Pinsir", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pinsir Constructor waiting for no params
		/// </summary>
		/*
		public Pinsir() : this( "Pinsir", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}