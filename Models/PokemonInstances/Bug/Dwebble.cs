using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dwebble PokemonInstance Class
	#region Dwebble
	public class Dwebble : PokemonInstance
	{
		#region Dwebble Constructors
		/// <summary>
		/// Dwebble Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dwebble(string nickname, int level)
		: base(
				DwebbleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dwebble Constructor only waiting for a Level
		/// </summary>
		public Dwebble(int level)
		: this( "Dwebble", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dwebble Constructor waiting for no params
		/// </summary>
		/*
		public Dwebble() : this( "Dwebble", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}