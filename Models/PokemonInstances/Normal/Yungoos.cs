using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Yungoos PokemonInstance Class
	#region Yungoos
	public class Yungoos : PokemonInstance
	{
		#region Yungoos Constructors
		/// <summary>
		/// Yungoos Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Yungoos(string nickname, int level)
		: base(
				YungoosSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yungoos Constructor only waiting for a Level
		/// </summary>
		public Yungoos(int level)
		: this( "Yungoos", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yungoos Constructor waiting for no params
		/// </summary>
		/*
		public Yungoos() : this( "Yungoos", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}