using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gardevoir PokemonInstance Class
	#region Gardevoir
	public class Gardevoir : PokemonInstance
	{
		#region Gardevoir Constructors
		/// <summary>
		/// Gardevoir Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gardevoir(string nickname, int level)
		: base(
				GardevoirSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gardevoir Constructor only waiting for a Level
		/// </summary>
		public Gardevoir(int level)
		: this( "Gardevoir", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gardevoir Constructor waiting for no params
		/// </summary>
		/*
		public Gardevoir() : this( "Gardevoir", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}