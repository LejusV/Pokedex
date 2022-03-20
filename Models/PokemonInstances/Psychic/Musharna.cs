using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Musharna PokemonInstance Class
	#region Musharna
	public class Musharna : PokemonInstance
	{
		#region Musharna Constructors
		/// <summary>
		/// Musharna Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Musharna(string nickname, int level)
		: base(
				MusharnaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Musharna Constructor only waiting for a Level
		/// </summary>
		public Musharna(int level)
		: this( "Musharna", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Musharna Constructor waiting for no params
		/// </summary>
		/*
		public Musharna() : this( "Musharna", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}