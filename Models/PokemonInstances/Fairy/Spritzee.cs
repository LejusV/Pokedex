using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Spritzee PokemonInstance Class
	#region Spritzee
	public class Spritzee : PokemonInstance
	{
		#region Spritzee Constructors
		/// <summary>
		/// Spritzee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Spritzee(string nickname, int level)
		: base(
				SpritzeeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spritzee Constructor only waiting for a Level
		/// </summary>
		public Spritzee(int level)
		: this( "Spritzee", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spritzee Constructor waiting for no params
		/// </summary>
		/*
		public Spritzee() : this( "Spritzee", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}