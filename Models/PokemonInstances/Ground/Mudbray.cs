using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mudbray PokemonInstance Class
	#region Mudbray
	public class Mudbray : PokemonInstance
	{
		#region Mudbray Constructors
		/// <summary>
		/// Mudbray Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mudbray(string nickname, int level)
		: base(
				MudbraySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudbray Constructor only waiting for a Level
		/// </summary>
		public Mudbray(int level)
		: this( "Mudbray", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudbray Constructor waiting for no params
		/// </summary>
		/*
		public Mudbray() : this( "Mudbray", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}