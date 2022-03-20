using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sharpedo PokemonInstance Class
	#region Sharpedo
	public class Sharpedo : PokemonInstance
	{
		#region Sharpedo Constructors
		/// <summary>
		/// Sharpedo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sharpedo(string nickname, int level)
		: base(
				SharpedoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sharpedo Constructor only waiting for a Level
		/// </summary>
		public Sharpedo(int level)
		: this( "Sharpedo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sharpedo Constructor waiting for no params
		/// </summary>
		/*
		public Sharpedo() : this( "Sharpedo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}