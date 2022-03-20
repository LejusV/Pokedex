using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Maractus PokemonInstance Class
	#region Maractus
	public class Maractus : PokemonInstance
	{
		#region Maractus Constructors
		/// <summary>
		/// Maractus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Maractus(string nickname, int level)
		: base(
				MaractusSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Maractus Constructor only waiting for a Level
		/// </summary>
		public Maractus(int level)
		: this( "Maractus", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Maractus Constructor waiting for no params
		/// </summary>
		/*
		public Maractus() : this( "Maractus", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}