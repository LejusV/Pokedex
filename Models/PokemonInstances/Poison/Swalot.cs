using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Swalot PokemonInstance Class
	#region Swalot
	public class Swalot : PokemonInstance
	{
		#region Swalot Constructors
		/// <summary>
		/// Swalot Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Swalot(string nickname, int level)
		: base(
				SwalotSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swalot Constructor only waiting for a Level
		/// </summary>
		public Swalot(int level)
		: this( "Swalot", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swalot Constructor waiting for no params
		/// </summary>
		/*
		public Swalot() : this( "Swalot", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}