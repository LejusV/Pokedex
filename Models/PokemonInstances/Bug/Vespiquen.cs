using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Vespiquen PokemonInstance Class
	#region Vespiquen
	public class Vespiquen : PokemonInstance
	{
		#region Vespiquen Constructors
		/// <summary>
		/// Vespiquen Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Vespiquen(string nickname, int level)
		: base(
				VespiquenSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vespiquen Constructor only waiting for a Level
		/// </summary>
		public Vespiquen(int level)
		: this( "Vespiquen", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vespiquen Constructor waiting for no params
		/// </summary>
		/*
		public Vespiquen() : this( "Vespiquen", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}