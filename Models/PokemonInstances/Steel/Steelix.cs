using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Steelix PokemonInstance Class
	#region Steelix
	public class Steelix : PokemonInstance
	{
		#region Steelix Constructors
		/// <summary>
		/// Steelix Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Steelix(string nickname, int level)
		: base(
				SteelixSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Steelix Constructor only waiting for a Level
		/// </summary>
		public Steelix(int level)
		: this( "Steelix", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Steelix Constructor waiting for no params
		/// </summary>
		/*
		public Steelix() : this( "Steelix", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}