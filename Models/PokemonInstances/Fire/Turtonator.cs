using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Turtonator PokemonInstance Class
	#region Turtonator
	public class Turtonator : PokemonInstance
	{
		#region Turtonator Constructors
		/// <summary>
		/// Turtonator Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Turtonator(string nickname, int level)
		: base(
				TurtonatorSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Turtonator Constructor only waiting for a Level
		/// </summary>
		public Turtonator(int level)
		: this( "Turtonator", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Turtonator Constructor waiting for no params
		/// </summary>
		/*
		public Turtonator() : this( "Turtonator", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}