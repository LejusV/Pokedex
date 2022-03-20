using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Poliwrath PokemonInstance Class
	#region Poliwrath
	public class Poliwrath : PokemonInstance
	{
		#region Poliwrath Constructors
		/// <summary>
		/// Poliwrath Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Poliwrath(string nickname, int level)
		: base(
				PoliwrathSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwrath Constructor only waiting for a Level
		/// </summary>
		public Poliwrath(int level)
		: this( "Poliwrath", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwrath Constructor waiting for no params
		/// </summary>
		/*
		public Poliwrath() : this( "Poliwrath", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}