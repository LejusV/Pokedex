using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Volcanion PokemonInstance Class
	#region Volcanion
	public class Volcanion : PokemonInstance
	{
		#region Volcanion Constructors
		/// <summary>
		/// Volcanion Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Volcanion(string nickname, int level)
		: base(
				VolcanionSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volcanion Constructor only waiting for a Level
		/// </summary>
		public Volcanion(int level)
		: this( "Volcanion", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volcanion Constructor waiting for no params
		/// </summary>
		/*
		public Volcanion() : this( "Volcanion", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}