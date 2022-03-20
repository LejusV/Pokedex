using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Venomoth PokemonInstance Class
	#region Venomoth
	public class Venomoth : PokemonInstance
	{
		#region Venomoth Constructors
		/// <summary>
		/// Venomoth Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Venomoth(string nickname, int level)
		: base(
				VenomothSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venomoth Constructor only waiting for a Level
		/// </summary>
		public Venomoth(int level)
		: this( "Venomoth", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venomoth Constructor waiting for no params
		/// </summary>
		/*
		public Venomoth() : this( "Venomoth", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}