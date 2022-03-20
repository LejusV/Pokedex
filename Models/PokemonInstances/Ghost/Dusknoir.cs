using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dusknoir PokemonInstance Class
	#region Dusknoir
	public class Dusknoir : PokemonInstance
	{
		#region Dusknoir Constructors
		/// <summary>
		/// Dusknoir Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dusknoir(string nickname, int level)
		: base(
				DusknoirSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dusknoir Constructor only waiting for a Level
		/// </summary>
		public Dusknoir(int level)
		: this( "Dusknoir", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dusknoir Constructor waiting for no params
		/// </summary>
		/*
		public Dusknoir() : this( "Dusknoir", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}