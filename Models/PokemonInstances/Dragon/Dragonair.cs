using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dragonair PokemonInstance Class
	#region Dragonair
	public class Dragonair : PokemonInstance
	{
		#region Dragonair Constructors
		/// <summary>
		/// Dragonair Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dragonair(string nickname, int level)
		: base(
				DragonairSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragonair Constructor only waiting for a Level
		/// </summary>
		public Dragonair(int level)
		: this( "Dragonair", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragonair Constructor waiting for no params
		/// </summary>
		/*
		public Dragonair() : this( "Dragonair", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}