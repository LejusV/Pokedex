using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Chimchar PokemonInstance Class
	#region Chimchar
	public class Chimchar : PokemonInstance
	{
		#region Chimchar Constructors
		/// <summary>
		/// Chimchar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Chimchar(string nickname, int level)
		: base(
				ChimcharSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chimchar Constructor only waiting for a Level
		/// </summary>
		public Chimchar(int level)
		: this( "Chimchar", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chimchar Constructor waiting for no params
		/// </summary>
		/*
		public Chimchar() : this( "Chimchar", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}