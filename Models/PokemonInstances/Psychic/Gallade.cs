using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gallade PokemonInstance Class
	#region Gallade
	public class Gallade : PokemonInstance
	{
		#region Gallade Constructors
		/// <summary>
		/// Gallade Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gallade(string nickname, int level)
		: base(
				GalladeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gallade Constructor only waiting for a Level
		/// </summary>
		public Gallade(int level)
		: this( "Gallade", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gallade Constructor waiting for no params
		/// </summary>
		/*
		public Gallade() : this( "Gallade", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}