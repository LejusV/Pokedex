using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Guzzlord PokemonInstance Class
	#region Guzzlord
	public class Guzzlord : PokemonInstance
	{
		#region Guzzlord Constructors
		/// <summary>
		/// Guzzlord Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Guzzlord(string nickname, int level)
		: base(
				GuzzlordSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Guzzlord Constructor only waiting for a Level
		/// </summary>
		public Guzzlord(int level)
		: this( "Guzzlord", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Guzzlord Constructor waiting for no params
		/// </summary>
		/*
		public Guzzlord() : this( "Guzzlord", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}