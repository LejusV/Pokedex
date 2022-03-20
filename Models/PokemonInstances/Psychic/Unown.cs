using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Unown PokemonInstance Class
	#region Unown
	public class Unown : PokemonInstance
	{
		#region Unown Constructors
		/// <summary>
		/// Unown Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Unown(string nickname, int level)
		: base(
				UnownSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Unown Constructor only waiting for a Level
		/// </summary>
		public Unown(int level)
		: this( "Unown", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Unown Constructor waiting for no params
		/// </summary>
		/*
		public Unown() : this( "Unown", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}