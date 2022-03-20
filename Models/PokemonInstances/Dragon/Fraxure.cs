using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Fraxure PokemonInstance Class
	#region Fraxure
	public class Fraxure : PokemonInstance
	{
		#region Fraxure Constructors
		/// <summary>
		/// Fraxure Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Fraxure(string nickname, int level)
		: base(
				FraxureSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fraxure Constructor only waiting for a Level
		/// </summary>
		public Fraxure(int level)
		: this( "Fraxure", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fraxure Constructor waiting for no params
		/// </summary>
		/*
		public Fraxure() : this( "Fraxure", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}