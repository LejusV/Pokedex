using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Vibrava PokemonInstance Class
	#region Vibrava
	public class Vibrava : PokemonInstance
	{
		#region Vibrava Constructors
		/// <summary>
		/// Vibrava Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Vibrava(string nickname, int level)
		: base(
				VibravaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vibrava Constructor only waiting for a Level
		/// </summary>
		public Vibrava(int level)
		: this( "Vibrava", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vibrava Constructor waiting for no params
		/// </summary>
		/*
		public Vibrava() : this( "Vibrava", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}