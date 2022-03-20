using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Scatterbug PokemonInstance Class
	#region Scatterbug
	public class Scatterbug : PokemonInstance
	{
		#region Scatterbug Constructors
		/// <summary>
		/// Scatterbug Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Scatterbug(string nickname, int level)
		: base(
				ScatterbugSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scatterbug Constructor only waiting for a Level
		/// </summary>
		public Scatterbug(int level)
		: this( "Scatterbug", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scatterbug Constructor waiting for no params
		/// </summary>
		/*
		public Scatterbug() : this( "Scatterbug", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}