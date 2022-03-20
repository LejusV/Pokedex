using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Zweilous PokemonInstance Class
	#region Zweilous
	public class Zweilous : PokemonInstance
	{
		#region Zweilous Constructors
		/// <summary>
		/// Zweilous Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Zweilous(string nickname, int level)
		: base(
				ZweilousSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zweilous Constructor only waiting for a Level
		/// </summary>
		public Zweilous(int level)
		: this( "Zweilous", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zweilous Constructor waiting for no params
		/// </summary>
		/*
		public Zweilous() : this( "Zweilous", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}