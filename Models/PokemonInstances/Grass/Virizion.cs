using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Virizion PokemonInstance Class
	#region Virizion
	public class Virizion : PokemonInstance
	{
		#region Virizion Constructors
		/// <summary>
		/// Virizion Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Virizion(string nickname, int level)
		: base(
				VirizionSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Virizion Constructor only waiting for a Level
		/// </summary>
		public Virizion(int level)
		: this( "Virizion", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Virizion Constructor waiting for no params
		/// </summary>
		/*
		public Virizion() : this( "Virizion", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}