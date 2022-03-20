using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bewear PokemonInstance Class
	#region Bewear
	public class Bewear : PokemonInstance
	{
		#region Bewear Constructors
		/// <summary>
		/// Bewear Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bewear(string nickname, int level)
		: base(
				BewearSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bewear Constructor only waiting for a Level
		/// </summary>
		public Bewear(int level)
		: this( "Bewear", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bewear Constructor waiting for no params
		/// </summary>
		/*
		public Bewear() : this( "Bewear", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}