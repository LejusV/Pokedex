using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cramorant PokemonInstance Class
	#region Cramorant
	public class Cramorant : PokemonInstance
	{
		#region Cramorant Constructors
		/// <summary>
		/// Cramorant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cramorant(string nickname, int level)
		: base(
				CramorantSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cramorant Constructor only waiting for a Level
		/// </summary>
		public Cramorant(int level)
		: this( "Cramorant", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cramorant Constructor waiting for no params
		/// </summary>
		/*
		public Cramorant() : this( "Cramorant", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}