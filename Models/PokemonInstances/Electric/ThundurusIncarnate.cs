using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Thundurus-Incarnate PokemonInstance Class
	#region Thundurus-Incarnate
	public class ThundurusIncarnate : PokemonInstance
	{
		#region Thundurus-Incarnate Constructors
		/// <summary>
		/// Thundurus-Incarnate Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ThundurusIncarnate(string nickname, int level)
		: base(
				ThundurusIncarnateSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thundurus-Incarnate Constructor only waiting for a Level
		/// </summary>
		public ThundurusIncarnate(int level)
		: this( "Thundurus-Incarnate", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thundurus-Incarnate Constructor waiting for no params
		/// </summary>
		/*
		public ThundurusIncarnate() : this( "Thundurus-Incarnate", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}