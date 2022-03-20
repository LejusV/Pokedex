using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pelipper PokemonInstance Class
	#region Pelipper
	public class Pelipper : PokemonInstance
	{
		#region Pelipper Constructors
		/// <summary>
		/// Pelipper Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pelipper(string nickname, int level)
		: base(
				PelipperSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pelipper Constructor only waiting for a Level
		/// </summary>
		public Pelipper(int level)
		: this( "Pelipper", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pelipper Constructor waiting for no params
		/// </summary>
		/*
		public Pelipper() : this( "Pelipper", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}