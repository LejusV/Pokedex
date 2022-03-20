using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dragalge PokemonInstance Class
	#region Dragalge
	public class Dragalge : PokemonInstance
	{
		#region Dragalge Constructors
		/// <summary>
		/// Dragalge Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dragalge(string nickname, int level)
		: base(
				DragalgeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragalge Constructor only waiting for a Level
		/// </summary>
		public Dragalge(int level)
		: this( "Dragalge", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragalge Constructor waiting for no params
		/// </summary>
		/*
		public Dragalge() : this( "Dragalge", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}