using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kingdra PokemonInstance Class
	#region Kingdra
	public class Kingdra : PokemonInstance
	{
		#region Kingdra Constructors
		/// <summary>
		/// Kingdra Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Kingdra(string nickname, int level)
		: base(
				KingdraSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kingdra Constructor only waiting for a Level
		/// </summary>
		public Kingdra(int level)
		: this( "Kingdra", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kingdra Constructor waiting for no params
		/// </summary>
		/*
		public Kingdra() : this( "Kingdra", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}