using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sableye PokemonInstance Class
	#region Sableye
	public class Sableye : PokemonInstance
	{
		#region Sableye Constructors
		/// <summary>
		/// Sableye Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sableye(string nickname, int level)
		: base(
				SableyeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sableye Constructor only waiting for a Level
		/// </summary>
		public Sableye(int level)
		: this( "Sableye", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sableye Constructor waiting for no params
		/// </summary>
		/*
		public Sableye() : this( "Sableye", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}