using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lopunny PokemonInstance Class
	#region Lopunny
	public class Lopunny : PokemonInstance
	{
		#region Lopunny Constructors
		/// <summary>
		/// Lopunny Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lopunny(string nickname, int level)
		: base(
				LopunnySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lopunny Constructor only waiting for a Level
		/// </summary>
		public Lopunny(int level)
		: this( "Lopunny", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lopunny Constructor waiting for no params
		/// </summary>
		/*
		public Lopunny() : this( "Lopunny", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}