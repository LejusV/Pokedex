using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Muk PokemonInstance Class
	#region Muk
	public class Muk : PokemonInstance
	{
		#region Muk Constructors
		/// <summary>
		/// Muk Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Muk(string nickname, int level)
		: base(
				MukSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Muk Constructor only waiting for a Level
		/// </summary>
		public Muk(int level)
		: this( "Muk", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Muk Constructor waiting for no params
		/// </summary>
		/*
		public Muk() : this( "Muk", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}