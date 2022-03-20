using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Barboach PokemonInstance Class
	#region Barboach
	public class Barboach : PokemonInstance
	{
		#region Barboach Constructors
		/// <summary>
		/// Barboach Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Barboach(string nickname, int level)
		: base(
				BarboachSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barboach Constructor only waiting for a Level
		/// </summary>
		public Barboach(int level)
		: this( "Barboach", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barboach Constructor waiting for no params
		/// </summary>
		/*
		public Barboach() : this( "Barboach", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}