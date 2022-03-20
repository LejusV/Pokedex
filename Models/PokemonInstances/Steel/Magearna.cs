using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Magearna PokemonInstance Class
	#region Magearna
	public class Magearna : PokemonInstance
	{
		#region Magearna Constructors
		/// <summary>
		/// Magearna Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Magearna(string nickname, int level)
		: base(
				MagearnaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magearna Constructor only waiting for a Level
		/// </summary>
		public Magearna(int level)
		: this( "Magearna", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magearna Constructor waiting for no params
		/// </summary>
		/*
		public Magearna() : this( "Magearna", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}