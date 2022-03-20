using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Spheal PokemonInstance Class
	#region Spheal
	public class Spheal : PokemonInstance
	{
		#region Spheal Constructors
		/// <summary>
		/// Spheal Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Spheal(string nickname, int level)
		: base(
				SphealSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spheal Constructor only waiting for a Level
		/// </summary>
		public Spheal(int level)
		: this( "Spheal", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spheal Constructor waiting for no params
		/// </summary>
		/*
		public Spheal() : this( "Spheal", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}