using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Wynaut PokemonInstance Class
	#region Wynaut
	public class Wynaut : PokemonInstance
	{
		#region Wynaut Constructors
		/// <summary>
		/// Wynaut Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Wynaut(string nickname, int level)
		: base(
				WynautSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wynaut Constructor only waiting for a Level
		/// </summary>
		public Wynaut(int level)
		: this( "Wynaut", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wynaut Constructor waiting for no params
		/// </summary>
		/*
		public Wynaut() : this( "Wynaut", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}