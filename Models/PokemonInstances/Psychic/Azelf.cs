using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Azelf PokemonInstance Class
	#region Azelf
	public class Azelf : PokemonInstance
	{
		#region Azelf Constructors
		/// <summary>
		/// Azelf Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Azelf(string nickname, int level)
		: base(
				AzelfSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azelf Constructor only waiting for a Level
		/// </summary>
		public Azelf(int level)
		: this( "Azelf", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azelf Constructor waiting for no params
		/// </summary>
		/*
		public Azelf() : this( "Azelf", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}