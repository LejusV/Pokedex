using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cubone PokemonInstance Class
	#region Cubone
	public class Cubone : PokemonInstance
	{
		#region Cubone Constructors
		/// <summary>
		/// Cubone Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cubone(string nickname, int level)
		: base(
				CuboneSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cubone Constructor only waiting for a Level
		/// </summary>
		public Cubone(int level)
		: this( "Cubone", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cubone Constructor waiting for no params
		/// </summary>
		/*
		public Cubone() : this( "Cubone", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}