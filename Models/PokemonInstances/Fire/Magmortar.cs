using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Magmortar PokemonInstance Class
	#region Magmortar
	public class Magmortar : PokemonInstance
	{
		#region Magmortar Constructors
		/// <summary>
		/// Magmortar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Magmortar(string nickname, int level)
		: base(
				MagmortarSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magmortar Constructor only waiting for a Level
		/// </summary>
		public Magmortar(int level)
		: this( "Magmortar", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magmortar Constructor waiting for no params
		/// </summary>
		/*
		public Magmortar() : this( "Magmortar", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}