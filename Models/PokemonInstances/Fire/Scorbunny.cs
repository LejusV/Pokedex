using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Scorbunny PokemonInstance Class
	#region Scorbunny
	public class Scorbunny : PokemonInstance
	{
		#region Scorbunny Constructors
		/// <summary>
		/// Scorbunny Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Scorbunny(string nickname, int level)
		: base(
				ScorbunnySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scorbunny Constructor only waiting for a Level
		/// </summary>
		public Scorbunny(int level)
		: this( "Scorbunny", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scorbunny Constructor waiting for no params
		/// </summary>
		/*
		public Scorbunny() : this( "Scorbunny", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}