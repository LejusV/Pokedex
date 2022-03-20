using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Shuckle PokemonInstance Class
	#region Shuckle
	public class Shuckle : PokemonInstance
	{
		#region Shuckle Constructors
		/// <summary>
		/// Shuckle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Shuckle(string nickname, int level)
		: base(
				ShuckleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shuckle Constructor only waiting for a Level
		/// </summary>
		public Shuckle(int level)
		: this( "Shuckle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shuckle Constructor waiting for no params
		/// </summary>
		/*
		public Shuckle() : this( "Shuckle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}