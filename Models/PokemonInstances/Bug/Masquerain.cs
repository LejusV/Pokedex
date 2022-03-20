using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Masquerain PokemonInstance Class
	#region Masquerain
	public class Masquerain : PokemonInstance
	{
		#region Masquerain Constructors
		/// <summary>
		/// Masquerain Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Masquerain(string nickname, int level)
		: base(
				MasquerainSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Masquerain Constructor only waiting for a Level
		/// </summary>
		public Masquerain(int level)
		: this( "Masquerain", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Masquerain Constructor waiting for no params
		/// </summary>
		/*
		public Masquerain() : this( "Masquerain", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}