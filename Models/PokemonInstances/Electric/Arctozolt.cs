using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Arctozolt PokemonInstance Class
	#region Arctozolt
	public class Arctozolt : PokemonInstance
	{
		#region Arctozolt Constructors
		/// <summary>
		/// Arctozolt Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Arctozolt(string nickname, int level)
		: base(
				ArctozoltSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arctozolt Constructor only waiting for a Level
		/// </summary>
		public Arctozolt(int level)
		: this( "Arctozolt", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arctozolt Constructor waiting for no params
		/// </summary>
		/*
		public Arctozolt() : this( "Arctozolt", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}