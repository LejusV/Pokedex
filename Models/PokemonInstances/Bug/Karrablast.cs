using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Karrablast PokemonInstance Class
	#region Karrablast
	public class Karrablast : PokemonInstance
	{
		#region Karrablast Constructors
		/// <summary>
		/// Karrablast Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Karrablast(string nickname, int level)
		: base(
				KarrablastSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Karrablast Constructor only waiting for a Level
		/// </summary>
		public Karrablast(int level)
		: this( "Karrablast", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Karrablast Constructor waiting for no params
		/// </summary>
		/*
		public Karrablast() : this( "Karrablast", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}